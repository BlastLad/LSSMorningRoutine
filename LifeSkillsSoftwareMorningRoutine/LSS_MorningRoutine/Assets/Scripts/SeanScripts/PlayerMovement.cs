using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Sound foot;

    public float runSpeed = 0;
    [SerializeField]
    private float turnSpeed = 0;
    [SerializeField]
    private float mouseSensitivity = 3.5f;

    [SerializeField]
    [Range(0.0f, 0.5f)] float mouseSmoothTime = 0.03f;

    float cameraPitch = 0.0f;


    Vector2 currentMouseDelta = Vector2.zero;
    Vector2 currentMouseDeltaVelocity = Vector2.zero;

    public PlayerControls characterControls;
    private Vector3 inputVector = new Vector3(0, 0);
    public Vector3 currentPosition;
    private Rigidbody rb;

    public Transform cameraLocation;


    public bool isMoving;
    [SerializeField]
    private bool canMove = true;

    bool atExit = false;


    InteractableObject currentInteractable;
    // Start is called before the first frame update
    void Awake()
    {
        characterControls = new PlayerControls();
        rb = GetComponent<Rigidbody>();


        Time.timeScale = 1f;
        characterControls.Base.Interact.started += ctx => InteractFunction();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Start()
    {

        foot = AudioManager.instance.GetSound("Footsteps");
    }

    private void Update()
    {
        currentPosition = transform.position;
        if (foot != null){
            if (isMoving && foot.source.isPlaying == false)
            {
                AudioManager.instance.PlaySoundIntervalToEnd(0f, "Footsteps");
            }
            else if (!isMoving && foot.source.isPlaying)
            {
                AudioManager.instance.StopSound("Footsteps");
            }
        }



        if (canMove == false)
        {
           // transform.rotation = Rotation;
        }

        UpdateMouseLook();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 position = rb.position;


        if (canMove == true)
        {
            if (inputVector != new Vector3(0, 0, 0))
            {
                isMoving = true;
             
            }
            else
            {
                isMoving = false;
            }

            position = position + MoveForwardBasedOnCamera(inputVector) * runSpeed * Time.fixedDeltaTime;

            rb.MovePosition(position);
        }
        else
        {
            isMoving = false;
        }
   
    }

    public Vector2 GetMouseDelta()
    {
        return characterControls.Base.CameraMovement.ReadValue<Vector2>();
    }


    public void SetCurrentInteractable(InteractableObject value)
    {
        currentInteractable = value;
    }

    public void SetInteractableExit(InteractableObject value, bool exit)
    {
        currentInteractable = value;
        atExit = exit;
    }

    public void InteractFunction()
    {

        if (currentInteractable != null && !atExit)
        {
            currentInteractable.moveScene();
        }
        else if (currentInteractable != null && atExit)
        {
            currentInteractable.enableEndScreen();
        }

        Debug.Log("Interact Function Called");
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

        if (cameraLocation != null)
        {

            Vector3 cameraLocationForward = cameraLocation.forward;
            Vector3 cameraLocationRight = cameraLocation.right;

            cameraLocationForward.y = 0;
            cameraLocationRight.y = 0;

            cameraLocationForward = cameraLocationForward.normalized;
            cameraLocationRight = cameraLocationRight.normalized;


            //Direction = new Vector3(inputVector.x, 0, inputVector.z);
            Direction = (cameraLocationForward * inputVector.z + cameraLocationRight * inputVector.x);
        }
       // transform.rotation = Rotation;
    }

    private Vector3 Direction { get; set; }

    //private Quaternion Rotation => Quaternion.LookRotation(RotationDirection);

   // private Vector3 RotationDirection =>
       // Vector3.RotateTowards(transform.forward, Direction, turnSpeed * Time.deltaTime, 0);


    public void UpdateMouseLook()
    {
        Vector2 targetMouseDelta = GetMouseDelta();

        currentMouseDelta = Vector2.SmoothDamp(currentMouseDelta, targetMouseDelta, ref currentMouseDeltaVelocity, mouseSmoothTime);

        cameraPitch -= currentMouseDelta.y * mouseSensitivity;

        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);

        cameraLocation.localEulerAngles = Vector3.right * cameraPitch;

        transform.Rotate(Vector3.up * currentMouseDelta.x * mouseSensitivity);
    }

    private void OnEnable()
    {
        characterControls.Enable();
    }

    private void OnDisable()
    {
        characterControls.Disable();
    }
}
