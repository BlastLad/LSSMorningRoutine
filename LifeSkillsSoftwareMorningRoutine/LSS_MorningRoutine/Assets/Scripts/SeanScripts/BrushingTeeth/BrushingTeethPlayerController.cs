using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushingTeethPlayerController : MonoBehaviour
{

    PlayerControls player;
    [SerializeField]
    LeftPlayerControl leftplayerControl;
    [SerializeField]
    RightPlayerControl rightplayerControl;

    private void Awake()
    {
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

    public void LeftClick()
    {
        leftplayerControl.destroyNote(true);
        Debug.Log("LEFT CLICK FIRED");
    }

    public void RightClick()
    {
        rightplayerControl.destroyNote(true);
        Debug.Log("RIGHT CLICK FIRED");
    }

    public void EndLeft()
    {
        Debug.Log("LEFT CLICK ENDED");
    }

    public void EndRight()
    {
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
