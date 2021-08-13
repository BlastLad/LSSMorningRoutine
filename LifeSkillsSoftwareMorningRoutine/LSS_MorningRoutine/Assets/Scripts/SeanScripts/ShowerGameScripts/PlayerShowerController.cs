using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
public class PlayerShowerController : MonoBehaviour
{
    PlayerControls playerControls;// Start is called before the first frame update
    private int CurrentTool = -1;//0 selection, 1 soap, 2 bodywash, 3 showerhead
    bool isToolinUse = false;
    float dragDepth;
    CinemachineVirtualCamera currentCam;
    public CinemachineVirtualCamera mainCam;
    public CinemachineVirtualCamera headCam;
    public CinemachineVirtualCamera leftCam;
    public CinemachineVirtualCamera rightCam;

    public CursorControl cursor;

    private List<float> MouseTrackerX = new List<float>();
    private List<float> MouseTrackerY = new List<float>();
    public int counter = 0;

    [SerializeField]
    public Sprite selectionMouse;
    public Sprite soapMouse;
    public Sprite bodyWashMouse;
    public Sprite showerheadMouse;

    private void Awake()
    {
        playerControls = new PlayerControls();

        currentCam = mainCam;   

        playerControls.ShowerGame.SelectionTool.performed += ctx => SelectionTool();
        playerControls.ShowerGame.SoapTool.performed += ctx => SoapTool();
        playerControls.ShowerGame.BodyWashTool.performed += ctx => ShampooTool();
        playerControls.ShowerGame.ShowerTool.performed += ctx => ShowerTool();
        playerControls.ShowerGame.ActivateTool.performed += ctx => ActivateTool();
        playerControls.ShowerGame.ActivateTool.canceled += ctx => CancelTool();
        playerControls.ShowerGame.SecondaryActivation.started += ctx => SecondActivation();
    }
    void Start()
    {
        SelectionTool();

        AudioManager.instance.Play("Shower Ambience");
    }

    // Update is called once per frame
    void Update()
    {
        if (AudioManager.instance.GetSound("Shower Ambience") != null)
        {
            if (AudioManager.instance.isPlaying("Shower Ambience") == false)
                AudioManager.instance.Play("Shower Ambience");
        }

        //Trying to play the scrub sound whenever the mouse changes direction.
        /*if(isToolinUse == true)
        {
            if(CurrentTool == 1)
            {
                MouseTrackerX.Add(Input.mousePosition.x);
                MouseTrackerY.Add(Input.mousePosition.y);
                counter += counter;

                if(counter > 1)
                {
                    if (MouseTrackerX[counter - 1] - MouseTrackerX[counter - 2] > 0){
                        if (MouseTrackerX[counter] - MouseTrackerX[counter - 1] < 0)
                            AudioManager.instance.Play("Scrub 1");
                    }
                    else if (MouseTrackerX[counter - 1] - MouseTrackerX[counter - 2] < 0){
                        if (MouseTrackerX[counter] - MouseTrackerX[counter - 1] > 0)
                            AudioManager.instance.Play("Scrub 2");
                    }
                    if (MouseTrackerY[counter - 1] - MouseTrackerY[counter - 2] > 0){
                        if (MouseTrackerY[counter] - MouseTrackerY[counter - 1] < 0)
                            AudioManager.instance.Play("Scrub 2");
                    }
                    else if (MouseTrackerY[counter - 1] - MouseTrackerY[counter - 2] < 0){
                        if (MouseTrackerY[counter] - MouseTrackerY[counter - 1] > 0)
                            AudioManager.instance.Play("Scrub 3");
                    }
                }
            }
        }

        if (isToolinUse == false) {
            counter = 0;
            MouseTrackerX.Clear();
            MouseTrackerY.Clear();
        } */
    }


    public void SelectionTool()
    {
        if (!isToolinUse)
        {
            CurrentTool = 0;
            cursor.SetSprite(selectionMouse);
            Debug.Log(CurrentTool + "Selection");
            AudioManager.instance.Play("Inspector");
        }
    }

    public void SoapTool()
    {
        if (!isToolinUse)
        { 
            CurrentTool = 1;
            cursor.SetSprite(soapMouse);
            Debug.Log(CurrentTool + "Soap");
            AudioManager.instance.Play("Soap");
        }
    }

    public void ShampooTool()
    {
        if (!isToolinUse)
        {
            CurrentTool = 2;
            cursor.SetSprite(bodyWashMouse);
            Debug.Log(CurrentTool + "Shampoo");
            AudioManager.instance.Play("Shampoo");
        }
    }

    public void ShowerTool()
    {
        if (!isToolinUse)
        {
            CurrentTool = 3;
            cursor.SetSprite(showerheadMouse);
            Debug.Log(CurrentTool + "Shower");
            AudioManager.instance.Play("Shower Head");
        }
    }

    public void ActivateTool()
    {
        isToolinUse = true;
        if (CurrentTool == 0)//Selection
        {
            ActivateSelectionTool();
        }
        else if(CurrentTool == 1)//Soap
        {
            ActivateSoapTool();
            Debug.Log(Mouse.current.position.ReadValue());
        }
        else if(CurrentTool == 2)//Shampoo
        {
            ActivateShampooTool();

        }
        else if (CurrentTool == 3)//Shower
        {
            ActivateShowerTool();
        }
    }

    public void CancelTool()
    {
        isToolinUse = false;     
        
        if (CurrentTool == 1)//Soap
        {
            CancelSoapTool();
        }
        else if (CurrentTool == 2)//Shampoo 
        {
            CancelShampooTool();
        }
        else if (CurrentTool == 3)//Shower
        {
            CancelShowerTool();
        }
    }

    public void ActivateSelectionTool()
    {
        var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;
        Debug.Log("fire");

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("hit" + hit.transform.name);

            if (hit.transform.gameObject.tag == "Head")
            {
                ChangeCam(headCam);
                AudioManager.instance.Play("Zoom in");
            }
            else if (hit.transform.gameObject.tag == "LeftArm")
            {
                ChangeCam(leftCam);
                AudioManager.instance.Play("Zoom in");
            }
            else if (hit.transform.gameObject.tag == "RightArm")
            {
                ChangeCam(rightCam);
                AudioManager.instance.Play("Zoom in");
            }
        }
    }

    public void ActivateSoapTool()
    {
        Debug.Log("SOAP TOOL NOW IN USE");
    }

    public void CancelSoapTool()
    {
        Debug.Log("SOAP TOOL NO LONGER IN USE");
    }

    public void ActivateShampooTool()
    {
        Debug.Log("SHAMPOO TOOL NOW IN USE");
    }

    public void CancelShampooTool()
    {
        Debug.Log("SHAMPOO TOOL NO LONGER IN USE");
    }
    public void ActivateShowerTool()
    {
        Debug.Log("SHOWER TOOL NOW IN USE");
    }

    public void CancelShowerTool()
    {
        Debug.Log("SHOWER TOOL NO LONGER IN USE");
    }

    public void ChangeCam(CinemachineVirtualCamera cam)
    {
        currentCam.Priority = 8;
        currentCam = cam;
        currentCam.Priority = 11;
    }

    public void SecondActivation()
    {
        if (CurrentTool == 0)
        {//selction 
            ChangeCam(mainCam);
            AudioManager.instance.Play("Zoom out");
        }
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}
