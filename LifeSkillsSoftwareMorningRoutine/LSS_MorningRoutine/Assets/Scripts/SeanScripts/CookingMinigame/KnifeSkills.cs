using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSkills : MonoBehaviour
{

    [SerializeField]
    Transform Point1;
    [SerializeField]
    Transform Point2;
    [SerializeField]
    Transform bottomPoint;
    [SerializeField]
    Transform nextPoint;

    [SerializeField]
    bool frontCam = true;

    [SerializeField]
    Transform nextCutPosition;//TEMPORARY WILL BE ACTUALLY BE DATA READ IN FROM OBJECT


    bool isMoving = false;
    bool isOnGround = false;
    int signSentinel = 1;//for positive or negative movement on an axis 1 and -1 only
    [SerializeField]
    float cutSpeed = 2f;

    float cutYMod = 0.1f;

    float rotationSpeed = 32f;

    PlayerControls knifeControls;


    public void SetFrontCam(bool val)
    {
        frontCam = val;
    }
    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            Vector3 position = transform.position;

            if (position.y <= bottomPoint.position.y)
            {
                cutYMod = 0;
                isOnGround = true;
            }

            position += new Vector3(0, -1 * (cutSpeed * cutYMod), signSentinel * cutSpeed) * Time.deltaTime;

            if (position.z < Point1.position.z || position.z > Point2.position.z)
            {
                return;
            }


            if (nextPoint == Point2)
            {
                var fromAngle = transform.rotation;
                var toAngle = Quaternion.Euler(transform.eulerAngles + new Vector3(1, 0, 0) * rotationSpeed * Time.deltaTime);
                float rotationNum = toAngle.x;             
                transform.rotation = new Quaternion(Mathf.Clamp(rotationNum, -0.1f, 0.1f), toAngle.y, toAngle.z, toAngle.w);
                

            }
            else if (nextPoint == Point1)
            {
                var fromAngle = transform.rotation;
                var toAngle = Quaternion.Euler(transform.eulerAngles + new Vector3(-1, 0, 0) * rotationSpeed * Time.deltaTime);
                float rotationNum = toAngle.x;
                transform.rotation = new Quaternion(Mathf.Clamp(rotationNum, -0.1f, 0.1f), toAngle.y, toAngle.z, toAngle.w);
                
            }

            transform.position = position;

           
        }
    }

    private void Awake()
    {
        knifeControls = new PlayerControls();//might change 


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

    void EnableCuttingForward(bool isFront)
    {

        if (nextPoint == Point2 && isFront == frontCam)
        {
            isMoving = true;
            signSentinel = 1;
            Debug.Log("YOU ARE CUTTING FORWARD");
        }

  
    }

    void DisableCuttingForward(bool isFront)
    {
        if (nextPoint == Point2 && isFront == frontCam)
        {
            isMoving = false;
            Debug.Log("YOU HAVE STOPPED CUTTING forward");
        }
    }


    void EnableCuttingBackward(bool isFront)
    {
        if (nextPoint == Point1 && isFront == frontCam)
        {
            isMoving = true;
            signSentinel = -1;
            Debug.Log("YOU ARE CUTTING BACKWARD");
        }

    }

    void DisableCuttingBackward(bool isFront)
    {
        if (nextPoint == Point1 && isFront == frontCam)
        {
            isMoving = false;
            Debug.Log("YOU HAVE STOPPED CUTTING BACK");
        }
    }


    public Transform ChangePoint(GameObject foodObject)
    {

        if (isOnGround)
        {
            cutYMod = 0.1f;
            isOnGround = false;
            isMoving = false;
            transform.rotation = new Quaternion(0, 0, 0, 0);
            Transform nextP = foodObject.GetComponent<FoodObjectData>().NextCut();

            if (nextP == null)
            {
                Debug.Log("MICROGAME FINISHED");
                //finishMinigame
            }
            else
            {
                transform.position = nextP.position;
                nextPoint = Point1;
                return nextPoint;
            }

       
        }


        if (nextPoint == Point2)
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
