using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using PaintIn3D;
using UnityEngine.UI;
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

    [SerializeField]
    GameObject[] selectionToolColliders;

    [SerializeField]
    GameObject PaintTool;
    [SerializeField]
    Color soapColor;
    [SerializeField]
    Color shampooColor;

    [SerializeField]
    GameObject FadeAwayObj;

    [SerializeField]
    GameObject showerParticles;

    [SerializeField]
    GameObject zoomOutGo;
    [SerializeField]
    Text leftMbText;

    string shampooReminderText = "Try using the Shampoo on your hair, not the bar of Soap!";
    string soapReminderText = "Try using the Soap bar on your body, not the Shampoo!";
    string leftMbSelectionText = "Zoom In";
    string leftMBOtherText = "Use Tool";

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
        if(isToolinUse == true)
        {
            if(CurrentTool == 1 && PaintTool.active)
            {
                MouseTrackerX.Add(Mouse.current.position.ReadValue().x);
                MouseTrackerY.Add(Mouse.current.position.ReadValue().y);
                counter++;
                if(counter > 10)
                {
                    if (MouseTrackerX[counter - 6] - MouseTrackerX[counter - 10] > 0){
                        if (MouseTrackerX[counter - 1] - MouseTrackerX[counter - 5] < 0)
                            AudioManager.instance.Play("Scrub 1 in");
                    }
                    if (MouseTrackerX[counter - 6] - MouseTrackerX[counter - 10] < 0){
                        if (MouseTrackerX[counter - 1] - MouseTrackerX[counter - 5] > 0)
                            AudioManager.instance.Play("Scrub 1 out");
                    }
                    if (MouseTrackerY[counter - 6] - MouseTrackerY[counter - 10] > 0){
                        if (MouseTrackerY[counter - 1] - MouseTrackerY[counter - 5] < 0)
                            AudioManager.instance.Play("Scrub 3 in");
                    }
                    if (MouseTrackerY[counter - 6] - MouseTrackerY[counter - 10] < 0){
                        if (MouseTrackerY[counter - 1] - MouseTrackerY[counter - 5] > 0)
                            AudioManager.instance.Play("Scrub 3 out");
                    }
                }
            }

            
        }


        if (isToolinUse == false) {
            counter = 0;
            MouseTrackerX.Clear();
            MouseTrackerY.Clear();
        } 
    }

    private void FixedUpdate()
    {
        if (CurrentTool == 0 && currentCam == mainCam)
        {
            ShowerGameManager.instance.SelectionToolOutline();
        }
    }

    public void SelectionTool()
    {
        if (!isToolinUse)
        {
            CurrentTool = 0;
            cursor.SetSprite(selectionMouse);
            zoomOutGo.SetActive(true);
            leftMbText.text = leftMbSelectionText;
            Debug.Log(CurrentTool + "Selection");
            AudioManager.instance.Play("Inspector");
        }
    }

    public void SoapTool()
    {
        if (!isToolinUse)
        { 
            CurrentTool = 1;
            if (currentCam == mainCam)
            {
                ShowerGameManager.instance.ResetOutlines();
            }
            zoomOutGo.SetActive(false);
            leftMbText.text = leftMBOtherText;
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
            if (currentCam == mainCam)
            {
                ShowerGameManager.instance.ResetOutlines();
            }
            zoomOutGo.SetActive(false);
            leftMbText.text = leftMBOtherText;
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
            if (currentCam == mainCam)
            {
                ShowerGameManager.instance.ResetOutlines();
            }
            zoomOutGo.SetActive(false);
            leftMbText.text = leftMBOtherText;
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

            foreach (GameObject camCollider in selectionToolColliders)
            {
                camCollider.SetActive(false);
            }

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
        if (currentCam == leftCam || currentCam == rightCam)
        {
            PaintTool.SetActive(true);
            PaintTool.GetComponent<P3dPaintSphere>().Color = soapColor;
            Debug.Log("SOAP TOOL NOW IN USE");
        }
        else if (currentCam == headCam)//warning message saying to use shampoo and not soap on your head
        {
            FadeAwayObj.SetActive(true);
            FadeAwayObj.GetComponent<FadeAway>().SetText(shampooReminderText);
        }
    }

    public void CancelSoapTool()
    {
        PaintTool.SetActive(false);
        Debug.Log("SOAP TOOL NO LONGER IN USE");
    }

    public void ActivateShampooTool()
    {
        if (currentCam == headCam)
        {
            PaintTool.SetActive(true);
            PaintTool.GetComponent<P3dPaintSphere>().Color = shampooColor;
            Debug.Log("SHAMPOO TOOL NOW IN USE");
        }
        else if (currentCam == leftCam || currentCam == rightCam)//warning message saying to use soap and not shampoo on your body
        {
            FadeAwayObj.SetActive(true);
            FadeAwayObj.GetComponent<FadeAway>().SetText(soapReminderText);
        }
    }

    public void CancelShampooTool()
    {
        PaintTool.SetActive(false);
        Debug.Log("SHAMPOO TOOL NO LONGER IN USE");
    }
    public void ActivateShowerTool()
    {
        showerParticles.SetActive(true);
        Debug.Log("SHOWER TOOL NOW IN USE");
    }

    public void CancelShowerTool()
    {
        showerParticles.SetActive(false);
        Debug.Log("SHOWER TOOL NO LONGER IN USE");
    }

    public void ChangeCam(CinemachineVirtualCamera cam)
    {
        currentCam.Priority = 8;
        currentCam = cam;
        currentCam.Priority = 11;
        if (currentCam == mainCam)
        {
            ShowerGameManager.instance.SetEvaluation(-1);//none
            cursor.mainSprite.SetActive(true);
            cursor.cursor = cursor.mainSprite.GetComponent<SpriteRenderer>();
            cursor.rightSprite.SetActive(false);
            cursor.headSprite.SetActive(false);
            cursor.leftSprite.SetActive(false);
        }
        else if (currentCam == rightCam)
        {
            ShowerGameManager.instance.SetEvaluation(2);//right
            ShowerGameManager.instance.ResetOutlines();
            cursor.mainSprite.SetActive(false);
            cursor.rightSprite.SetActive(true);
            cursor.cursor = cursor.rightSprite.GetComponent<SpriteRenderer>();
        }
        else if (currentCam == headCam)
        {
            ShowerGameManager.instance.SetEvaluation(0);//head
            ShowerGameManager.instance.ResetOutlines();
            cursor.mainSprite.SetActive(false);
            cursor.headSprite.SetActive(true);
            cursor.cursor = cursor.headSprite.GetComponent<SpriteRenderer>();
        }
        else
        {
            ShowerGameManager.instance.SetEvaluation(1);//left
            cursor.cursor = cursor.leftSprite.GetComponent<SpriteRenderer>();
            cursor.mainSprite.SetActive(false);
            cursor.leftSprite.SetActive(true);
            ShowerGameManager.instance.ResetOutlines();
        }
    }

    public void SecondActivation()
    {
        if (CurrentTool == 0 && currentCam != mainCam)
        {//selction       
            ChangeCam(mainCam);
            foreach (GameObject camCollider in selectionToolColliders)
            {
                camCollider.SetActive(true);
            }
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
