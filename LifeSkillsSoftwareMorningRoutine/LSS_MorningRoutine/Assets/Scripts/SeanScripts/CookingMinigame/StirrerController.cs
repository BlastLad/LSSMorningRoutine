using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StirrerController : MonoBehaviour
{
    //Audio Clip for mixing the bowl
    //Particle Effect


    [SerializeField]
    PlayerMixingController player;

    public float runSpeed = 0;
    [SerializeField]
    private float turnSpeed = 0;

    public PlayerControls characterControls;
    private Vector3 inputVector = new Vector3(0, 0);
    public Vector3 currentPosition;
    private Rigidbody rb;

    public Transform cameraLocation;

    PlayerInput playerStuff;

    public bool isMixing;
    [SerializeField]
    private bool canMove = true;
    bool isMovingForward = true;

    [SerializeField]
    float requiredMixPoints = 0;
    [SerializeField]
    float mixPoints = 0;
    // Start is called before the first frame update
    void Awake()
    {
        playerStuff = GetComponent<PlayerInput>();
      //  rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        characterControls = player.mixingControls;

        characterControls.MixingMicroGame.Spin.started += ctx => SetIsMixing(true, ctx.ReadValue<Vector2>());
        characterControls.MixingMicroGame.Spin.performed += ctx => SetIsMixing(true, ctx.ReadValue<Vector2>());
        characterControls.MixingMicroGame.Spin.canceled += ctx => SetIsMixing(false);

    }
    private void Update()
    {
        currentPosition = transform.position;

        if (isMixing)
        {
            mixPoints += 1 * Time.deltaTime;


            if (AudioManager.instance.isPlaying("Mixing") == false)
            {
                if (AudioManager.instance.GetTimesPlayed("Mixing") == 0)
                {
                    AudioManager.instance.Play("Mixing");
                }
                else if (AudioManager.instance.GetTimesPlayed("Mixing") > 0)
                {
                    AudioManager.instance.PlaySoundIntervalToEnd(1.1f, "Mixing");
                }
            }
        }

        if (!isMixing)
        {
            AudioManager.instance.setTimesPlayed(0, "Mixing");
            AudioManager.instance.StopSound("Mixing");
        }

        if (mixPoints >= requiredMixPoints)
        {
            CompleteMixingGame();
        }

    }

    public void CompleteMixingGame()
    {
        CookingMinigameManager.instance.GetNextMicrogame();//need victory screen
    }

    // Update is called once per frame
    void FixedUpdate()
    {

       



        if (inputVector != new Vector3(0, 0, 0))
        {
            isMixing = true;
            if (playerStuff.currentControlScheme == "Keyboard")
            {
                if (isMovingForward)
                {
                    transform.Rotate(0, 6.0f * turnSpeed * Time.deltaTime, 0);
                }
                else
                {
                    transform.Rotate(0, 6.0f * -turnSpeed * Time.deltaTime, 0);
                }
            }
            
        }
        else
        {
            isMixing = false;
        }
    }


    public bool GetIsMixing()
    {
        return isMixing;
    }

    public void SetIsMixing(bool val)
    {
        isMixing = val;
    }

    public void SetIsMixing(bool val, Vector2 input)
    {
        isMixing = val;

 
    }

    public Vector3 MoveForwardBasedOnCamera(Vector3 val)
    {
        Vector3 cameraLocationForward = cameraLocation.forward;
        Vector3 cameraLocationRight = cameraLocation.right;

        cameraLocationForward.y = 0;
        cameraLocationRight.y = 0;

        cameraLocationForward = cameraLocationForward.normalized;
        cameraLocationRight = cameraLocationRight.normalized;

        Vector3 inputVectorCam = (cameraLocationForward * inputVector.z + cameraLocationRight * inputVector.x);
        return inputVectorCam;
    }



    public void OnMovement(InputAction.CallbackContext context)
    {

        inputVector.x = context.ReadValue<Vector2>().x;
        inputVector.z = context.ReadValue<Vector2>().y;

        Vector3 cameraLocationForward = cameraLocation.forward;
        Vector3 cameraLocationRight = cameraLocation.right;

        cameraLocationForward.y = 0;
        cameraLocationRight.y = 0;

        cameraLocationForward = cameraLocationForward.normalized;
        cameraLocationRight = cameraLocationRight.normalized;

        if (inputVector.x > 0.01)
        {
            isMovingForward = true;
        }
        else
        {
            isMovingForward = false;
        }


        //Direction = new Vector3(inputVector.x, 0, inputVector.z);
        Direction = (cameraLocationForward * inputVector.z + cameraLocationRight * inputVector.x);
        transform.rotation = Rotation;
    }

    private Vector3 Direction { get; set; }

    private Quaternion Rotation => Quaternion.LookRotation(RotationDirection);

    private Vector3 RotationDirection =>
        Vector3.RotateTowards(transform.forward, Direction, turnSpeed * Time.deltaTime, 0);


    private void OnEnable()
    {
        if (characterControls != null)
        {
            characterControls.Enable();
        }
    }

    private void OnDisable()
    {
        if (characterControls != null)
        {
            characterControls.Disable();
        }
    }
}
