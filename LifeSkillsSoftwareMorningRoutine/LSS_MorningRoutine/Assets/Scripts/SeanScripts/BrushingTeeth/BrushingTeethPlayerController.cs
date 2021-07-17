using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushingTeethPlayerController : MonoBehaviour
{
    public static BrushingTeethPlayerController instance { get; private set; }

    PlayerControls player;
    [SerializeField]
    LeftPlayerControl leftplayerControl;
    [SerializeField]
    RightPlayerControl rightplayerControl;


    public bool leftHoldActive = false;
    public bool rightHoldActive = false;

    bool isLeftHolding = false;
    bool isRightHolding = false;



    private void Awake()
    {
        instance = this;

        player = new PlayerControls();

        player.BrushingTeethGame.LeftMouse.started += ctx => LeftClick();
        player.BrushingTeethGame.LeftMouse.canceled += ctx => EndLeft();
        player.BrushingTeethGame.RightMouse.started += ctx => RightClick();
        player.BrushingTeethGame.RightMouse.canceled += ctx => EndRight();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetLeftStatus()
    {
        return isLeftHolding;
    }

    public bool GetRightStatus()
    {
        return isRightHolding;
    }

    public void LeftClick()
    {
        isLeftHolding = true;
        leftplayerControl.destroyNote(true);
        Debug.Log("LEFT CLICK FIRED");
    }

    public void RightClick()
    {
        isRightHolding = true;
        rightplayerControl.destroyNote(true);
        Debug.Log("RIGHT CLICK FIRED");
    }

    public void EndLeft()
    {
        isLeftHolding = false;
        if (leftHoldActive)
        {
            leftplayerControl.destroyNote(true, leftplayerControl.GetLeftHolds()[0].endNote);
        }
        Debug.Log("LEFT CLICK ENDED");
    }

    public void EndRight()
    {
        isRightHolding = false;
        if (rightHoldActive)
        {
            rightplayerControl.destroyNote(true, rightplayerControl.GetRightHolds()[0].endNote);
        }
        Debug.Log("RIGHT CLICK ENDED");
    }


    private void OnEnable()
    {
        player.Enable();
    }

    private void OnDisable()
    {
        player.Disable();
    }
}
