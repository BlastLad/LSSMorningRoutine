using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowerGameManager : MonoBehaviour
{
    public static ShowerGameManager instance { get; private set; }

    bool isBoy;

    [SerializeField]
    GameObject boyObj;
    [SerializeField]
    GameObject girlObj;
    [SerializeField]
    P3dChannelCounterFill headFill;
    [SerializeField]
    P3dChannelCounterFill leftArmFill;
    [SerializeField]
    P3dChannelCounterFill rightArmFill;
    [SerializeField]
    Text explanationText;

    string selectionString = "Select a section";
    string latherString = "Wash up with the Soap Bar";
    string rinseString = "Rinse off with the Shower Head";
    string shampooString = "Wash your hair with the Shampoo";
    string completeString = "All clean here! Try another section";


    int currentSection = -1;

    public int headThreshold;
    public int headCleanValue;
    public int leftArmThreshold;
    public int leftArmCleanValue;
    public int rightArmThreshold;
    public int rightArmCleanValue;

    [SerializeField]
    bool leftArmReadyToRinse = false;
    [SerializeField]
    bool rightArmReadyToRinse = false;
    [SerializeField]
    bool headReadyToRinse = false;

    [SerializeField]
    bool leftArmClean = false;
    [SerializeField]
    bool rightArmClean = false;
    [SerializeField]
    bool headClean = false;

    [SerializeField]
    Collider charCollider;

    [SerializeField]
    List<P3dPaintableTexture> charTextures;
    [SerializeField]
    List<P3dChannelCounterFill> charFill;//0 head 1 left 2 right
    [SerializeField]
    List<P3dChannelCounterText> charText;//0 head 1 left 2 right

    [SerializeField]
    GameObject endScreen;
    [SerializeField]
    GameObject explanationGO;
    [SerializeField]
    GameObject toolWheel;
    [SerializeField]
    PlayerShowerController playerShower;
    [SerializeField]
    GameObject toolControls;
    [SerializeField]
    GameObject cursor;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        isBoy = PlayerStats.isBoy;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if (isBoy)
        {
            SetBoy();
        }
        else
        {
            SetGirl();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (currentSection != -2)
        {
            EvaluateHead();
            EvaluateLeftArm();
            EvaluateRightArm();
        }        

        if (headClean && leftArmClean && rightArmClean && currentSection == -1)
        {
            EnableEndScreen();
            currentSection = -2;
        }
    }

    public void EnableEndScreen()
    {
        endScreen.SetActive(true);
        toolWheel.SetActive(false);
        explanationGO.SetActive(false);
        playerShower.enabled = false;
        Cursor.visible = true;
        AudioManager.instance.Play("Sparkle");
        Debug.Log("CONGRATS YOU WON");
    }

    public void StartGame()
    {
        playerShower.enabled = true;
        explanationGO.SetActive(true);
        toolControls.SetActive(true);
        cursor.SetActive(true);
        Cursor.visible = false;
    }

    public void ReturnToMain()
    {
        PlayerStats.isShowered = true;
        SceneManager.LoadScene(5);
    }

    public void setMouse(Texture2D image)
    {
        Cursor.SetCursor(image, hotSpot, cursorMode);
    }


    public void SetBoy()
    {
        boyObj.SetActive(true);
        CharDataShowerGame boyData = boyObj.GetComponent<CharDataShowerGame>();
        charCollider = boyData.charCollider;
        for (int i = 0; i < boyData.charTextures.Count; i++)
        {
            charTextures.Add(boyData.charTextures[i]);
            charFill[i].Counters[0] = boyData.charTextures[i].GetComponent<P3dChannelCounter>();
            charText[i].Counters[0] = boyData.charTextures[i].GetComponent<P3dChannelCounter>();
        }
    }


    public void SetGirl()
    {
        girlObj.SetActive(true);
        CharDataShowerGame girlData = girlObj.GetComponent<CharDataShowerGame>();
        charCollider = girlData.charCollider;
        for (int i = 0; i < girlData.charTextures.Count; i++)
        {
            Debug.Log(i);
            charTextures.Add(girlData.charTextures[i]);
            charFill[i].Counters[0] = girlData.charTextures[i].GetComponent<P3dChannelCounter>();
            charText[i].Counters[0] = girlData.charTextures[i].GetComponent<P3dChannelCounter>();
        }
    }


    public void SelectionToolOutline()
    {
        var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {

            if (hit.transform.gameObject.tag == "Head")
            {
                charTextures[0].GetComponent<Outline>().enabled = true;
                charTextures[1].GetComponent<Outline>().enabled = false;
                charTextures[2].GetComponent<Outline>().enabled = false;
            }
            else if (hit.transform.gameObject.tag == "LeftArm")
            {
                charTextures[1].GetComponent<Outline>().enabled = true;
                charTextures[0].GetComponent<Outline>().enabled = false;
                charTextures[2].GetComponent<Outline>().enabled = false;
            }
            else if (hit.transform.gameObject.tag == "RightArm")
            {
                charTextures[2].GetComponent<Outline>().enabled = true;
                charTextures[0].GetComponent<Outline>().enabled = false;
                charTextures[1].GetComponent<Outline>().enabled = false;
            }
            else
            {
                ResetOutlines();
            }

        }
    }

    public void ResetOutlines()
    {
        foreach (P3dPaintableTexture textureItem in charTextures)
        {
            textureItem.GetComponent<Outline>().enabled = false;
        }
    }

    public void SetEvaluation(int num)
    {
        currentSection = num;
        if (currentSection == 1 || currentSection == 2)//left / right arm
        {
            charCollider.gameObject.GetComponent<P3dPaintable>().enabled = false;
        }
        else
        {
            charCollider.gameObject.GetComponent<P3dPaintable>().enabled = true;
        }


        if (currentSection == -1)
        {
            explanationText.text = selectionString;
        }
        else if (currentSection == 1) 
        {
            if (leftArmReadyToRinse && !leftArmClean)
            {
                explanationText.text = rinseString;
            }
            else if (leftArmClean)
            {
                explanationText.text = completeString;
                AudioManager.instance.Play("Sparkle");
            }
            else
            {
                explanationText.text = latherString;
            }
        }
        else if (currentSection == 2)
        {
            if (rightArmReadyToRinse && !rightArmClean)
            {
                explanationText.text = rinseString;
            }
            else if (rightArmClean)
            {
                explanationText.text = completeString;
                AudioManager.instance.Play("Sparkle");
            }
            else
            {
                explanationText.text = latherString;
            }
        }
        else if (currentSection == 0)
        {
            if (headReadyToRinse && !headClean)
            {
                explanationText.text = rinseString;
            }
            else if (headClean)
            {
                explanationText.text = completeString;
                AudioManager.instance.Play("Sparkle");
            }
            else
            {
                explanationText.text = shampooString;
            }            
        }
    }

    public void EvaluateHead()
    {
        if (headFill.GetFillAmount() >= headThreshold && !headReadyToRinse)
        {
            headReadyToRinse = true;
            explanationText.text = rinseString;
            Debug.Log("HEAD READY TO RINSE");
        }

        if (headReadyToRinse && !headClean && headFill.GetFillAmount() <= headCleanValue)
        {
            headClean = true;
            explanationText.text = completeString;
            AudioManager.instance.Play("Sparkle");
            charTextures[0].Clear();
            Debug.Log("HEAD IS NOW CLEAN");
        }
    }

    public void EvaluateLeftArm()
    {
        if (leftArmFill.GetFillAmount() >= leftArmThreshold && !leftArmReadyToRinse)
        {
            leftArmReadyToRinse = true;
            explanationText.text = rinseString;
            Debug.Log("LEFT ARM READY TO RINSE");
        }

        if (leftArmReadyToRinse && !leftArmClean && leftArmFill.GetFillAmount() <= leftArmCleanValue)
        {
            leftArmClean = true;
            explanationText.text = completeString;
            AudioManager.instance.Play("Sparkle");
            charTextures[1].Clear();
            Debug.Log("LEFT ARM IS NOW CLEAN");
        }
    }

    public void EvaluateRightArm()
    {
        if (rightArmFill.GetFillAmount() >= rightArmThreshold && !rightArmReadyToRinse)
        {
            rightArmReadyToRinse = true;
            explanationText.text = rinseString;
            Debug.Log("RIGHT ARM TO RINSE");
        }

        if (rightArmReadyToRinse && !rightArmClean && rightArmFill.GetFillAmount() <= rightArmCleanValue)
        {
            rightArmClean = true;
            explanationText.text = completeString;
            AudioManager.instance.Play("Sparkle");
            charTextures[2].Clear();
            Debug.Log("righT ARM IS NOW CLEAN");
        }
    }
}
