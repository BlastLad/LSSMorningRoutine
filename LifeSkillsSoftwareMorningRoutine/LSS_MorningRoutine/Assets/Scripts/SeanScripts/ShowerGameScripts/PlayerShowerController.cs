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
        playerControls.ShowerGame.BodyWashTool.performed += ctx => BodyWashTool();
        playerControls.ShowerGame.ShowerTool.performed += ctx => ShowerTool();
        playerControls.ShowerGame.ActivateTool.performed += ctx => ActivateTool();
        playerControls.ShowerGame.ActivateTool.canceled += ctx => CancelTool();
        playerControls.ShowerGame.SecondaryActivation.started += ctx => SecondActivation();
    }
    void Start()
    {
        SelectionTool();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectionTool()
    {
        if (!isToolinUse)
        {
            CurrentTool = 0;
            cursor.SetSprite(selectionMouse);
            Debug.Log(CurrentTool + "Selection");
        }
    }

    public void SoapTool()
    {
        if (!isToolinUse)
        { 
            CurrentTool = 1;
            cursor.SetSprite(soapMouse);
            Debug.Log(CurrentTool + "Soap");
        }
    }

    public void BodyWashTool()
    {
        if (!isToolinUse)
        {
            CurrentTool = 2;
            cursor.SetSprite(bodyWashMouse);
            Debug.Log(CurrentTool + "BodyWash");
        }
    }

    public void ShowerTool()
    {
        if (!isToolinUse)
        {
            CurrentTool = 3;
            cursor.SetSprite(showerheadMouse);
            Debug.Log(CurrentTool + "Shower");
        }
    }

    public void ActivateTool()
    {
        isToolinUse = true;
        if (CurrentTool == 0)
        {
            ActivateSelectionTool();
        }
    }

    public void CancelTool()
    {
        isToolinUse = false;        
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
            }
            else if (hit.transform.gameObject.tag == "LeftArm")
            {
                ChangeCam(leftCam);
            }
            else if (hit.transform.gameObject.tag == "RightArm")
            {
                ChangeCam(rightCam);
            }
        }
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
