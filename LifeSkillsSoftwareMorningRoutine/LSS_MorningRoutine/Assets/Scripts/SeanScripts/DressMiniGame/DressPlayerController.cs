using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DressPlayerController : MonoBehaviour
{

    public PlayerControls dressCharacterControls;

    public Sound Hanger;
    public Sound Beach;
    public Sound Casual;
    public Sound School;
    public Sound Work;
    AudioSource audiosource;

    private void Awake()
    {
        dressCharacterControls = new PlayerControls();
        dressCharacterControls.DressMinigame.Enable();
        dressCharacterControls.Base.Disable();

        dressCharacterControls.DressMinigame.Select.started += ctx => SelectSection();

        dressCharacterControls.DressMinigame.MoveLeft.started += ctx => GoLeft();
        dressCharacterControls.DressMinigame.MoveRight.started += ctx => GoRight();
    }

    public void GoLeft()
    {
        DressMiniGameManager.instance.GoLeft();
        
    }

    public void GoRight()
    {
        DressMiniGameManager.instance.GoRight();

    }
    public void SelectSection()
    {
        
    }
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        dressCharacterControls.Enable();
        dressCharacterControls.DressMinigame.Enable();
        dressCharacterControls.Base.Disable();
    }

    private void OnDisable()
    {
        dressCharacterControls.Disable();

    }
}
