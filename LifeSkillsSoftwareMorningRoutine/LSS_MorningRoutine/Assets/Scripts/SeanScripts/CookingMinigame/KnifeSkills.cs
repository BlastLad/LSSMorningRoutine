using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSkills : MonoBehaviour
{

    [SerializeField]
    Transform Point1;//Point where knife drection changes
    [SerializeField]
    Transform Point2;//Point where knife direction changes
    [SerializeField]
    Transform bottomPoint;//When the Knife Touches the ground or cutting board
    [SerializeField]
    Transform nextPoint;// The next cutting point Either Point1 or 2

    [SerializeField]
    bool frontCam = true;//If the camera is in the front or side

    [SerializeField]
    Transform nextCutPosition;//TEMPORARY WILL BE ACTUALLY BE DATA READ IN FROM OBJECT


    bool isMoving = false;//Wether or not the knife is cutting
    bool isOnGround = false;//Wether or not the knife is on the ground
    int signSentinel = 1;//for positive or negative movement on an axis 1 and -1 only
    [SerializeField]
    float cutSpeed = 2f;//The speed of the knife

    float cutYMod = 0.1f;// The speed that the knife moves down

    float rotationSpeed = 32f;// The knife's little cutting speed

    PlayerControls knifeControls;
    public Sound Cutting;

    public void SetFrontCam(bool val)//Sets wether or not the camera is facing the front or side of the cuttable object
    {
        frontCam = val;
    }
    // Update is called once per frame
    void Update()
    {
        Cutting = AudioManager.instance.GetSound("Cutting");

        if (isMoving)//if the knife is cutting or not
        {
            if(Cutting != null)
            {
                if (Cutting.source.isPlaying == false)
                    if (AudioManager.instance.GetTimesPlayed("Cutting") >= 1)
                    {
                        AudioManager.instance.PlaySoundInterval(1.1f, 2f, "Cutting");
                    }

               else if(AudioManager.instance.GetTimesPlayed("Cutting") == 0)
                {
                    AudioManager.instance.PlaySoundIntervalToEnd(0f, "Cutting");
                }
            }

            Vector3 position = transform.position;

            if (position.y <= bottomPoint.position.y)
            {
                cutYMod = 0;
                isOnGround = true;
            }

            position += new Vector3(0, -1 * (cutSpeed * cutYMod), signSentinel * cutSpeed) * Time.deltaTime;

            if (position.z < Point1.position.z || position.z > Point2.position.z)//code that keeps the knife in bounds
            {
                return;
            }


            if (nextPoint == Point2)//code that rotates the knife
            {
                var fromAngle = transform.rotation;
                var toAngle = Quaternion.Euler(transform.eulerAngles + new Vector3(1, 0, 0) * rotationSpeed * Time.deltaTime);
                float rotationNum = toAngle.x;             
                transform.rotation = new Quaternion(Mathf.Clamp(rotationNum, -0.1f, 0.1f), toAngle.y, toAngle.z, toAngle.w);
                

            }
            else if (nextPoint == Point1)//code that rotates the knife
            {
                var fromAngle = transform.rotation;
                var toAngle = Quaternion.Euler(transform.eulerAngles + new Vector3(-1, 0, 0) * rotationSpeed * Time.deltaTime);
                float rotationNum = toAngle.x;
                transform.rotation = new Quaternion(Mathf.Clamp(rotationNum, -0.1f, 0.1f), toAngle.y, toAngle.z, toAngle.w);
                
            }

            transform.position = position;//The code that actually moves the knife


        }
        if (Cutting.source.isPlaying && !isMoving)
        {
            AudioManager.instance.StopSound("Cutting");
            AudioManager.instance.setTimesPlayed(0, "Cutting");
        }
    }

    private void Awake()
    {

        knifeControls = new PlayerControls();//might change 


    }

    public void EnableFromButton()
    {
       


        knifeControls.CuttingMicroGame.CutForward.started += ctx => EnableCuttingForward(true);
        knifeControls.CuttingMicroGame.CutLeft.started += ctx => EnableCuttingForward(false);
        knifeControls.CuttingMicroGame.CutLeft.canceled += ctx => DisableCuttingForward(false);
        knifeControls.CuttingMicroGame.CutForward.canceled += ctx => DisableCuttingForward(true);
        knifeControls.CuttingMicroGame.CutBackward.started += ctx => EnableCuttingBackward(true);
        knifeControls.CuttingMicroGame.CutRight.started += ctx => EnableCuttingBackward(false);
        knifeControls.CuttingMicroGame.CutBackward.canceled += ctx => DisableCuttingBackward(true);
        knifeControls.CuttingMicroGame.CutRight.canceled += ctx => DisableCuttingBackward(false);

        nextPoint = Point1;//One Closest to player view
    }

    void EnableCuttingForward(bool isFront)//Code for the buttons
    {

        if (nextPoint == Point2 && isFront == frontCam)
        {
            isMoving = true;
            signSentinel = 1;
            Debug.Log("YOU ARE CUTTING FORWARD");
        }

  
    }

    void DisableCuttingForward(bool isFront)//Code for the buttons
    {
        if (nextPoint == Point2 && isFront == frontCam)
        {
            isMoving = false;
            Debug.Log("YOU HAVE STOPPED CUTTING forward");
        }
    }


    void EnableCuttingBackward(bool isFront)//Code for the buttons
    {
        if (nextPoint == Point1 && isFront == frontCam)
        {
            isMoving = true;
            signSentinel = -1;
            Debug.Log("YOU ARE CUTTING BACKWARD");
        }

    }

    void DisableCuttingBackward(bool isFront)//Code for the buttons
    {
        if (nextPoint == Point1 && isFront == frontCam)
        {
            isMoving = false;
            Debug.Log("YOU HAVE STOPPED CUTTING BACK");
        }
    }


    public Transform ChangePoint(GameObject foodObject)//Code that changes the next next cutting point for both the foward and backward motion AND the next cutting point
    {
        int cuts = 0;

        if (isOnGround)//if you have reached the bottom of the cutting board (This will also be where the object is cut off from the rest of the model
        {
            cutYMod = 0.1f;
            isOnGround = false;
            isMoving = false;
            transform.rotation = new Quaternion(0, 0, 0, 0);
            Transform nextP = foodObject.GetComponent<FoodObjectData>().NextCut();

            

            if (nextP == null)
            {
                Debug.Log("MICROGAME FINISHED");
                CuttingMicroGameManager.instance.isCounting = false;
                CookingMinigameManager.instance.fillableField[CookingMinigameManager.instance.index].text = "" + CuttingMicroGameManager.instance.GetTimeSpentCutting().ToString("F2");
                CookingMinigameManager.instance.GetNextMicrogame();//IF THERE IS NO NEXT POINT THE MICRO GAME IS COMPLETE
                //finishMinigame
            }
            else
            {
                if (nextP.name == "Bread")
                {
                    foodObject.GetComponent<FoodObjectData>().orangeObject.SetActive(false);
                    foodObject.GetComponent<FoodObjectData>().breadObject.SetActive(true);
                }
                transform.position = nextP.position;
                nextPoint = Point1;
                return nextPoint;
            }
        }


        if (nextPoint == Point2)//changes between back and forth motion if not on the ground
        {
            nextPoint = Point1;
        }
        else
        {
            nextPoint = Point2;
        }


        

        return nextPoint;
    }

    public Transform getCurrentPoint()
    {
        return nextPoint;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }




    private void OnEnable()
    {
        knifeControls.Enable();
    }


    private void OnDisable()
    {
        knifeControls.Disable();
    }
}
