using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;
using UnityEngine.InputSystem;

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
 

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        isBoy = PlayerStats.isBoy;
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
        Debug.Log("CONGRATS YOU WON");
    }

    public void setMouse(Texture2D image)
    {
        Cursor.SetCursor(image, hotSpot, cursorMode);
    }


    public void SetBoy()
    {
        boyObj.SetActive(true);
    }


    public void SetGirl()
    {
        girlObj.SetActive(true);
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
    }

    public void EvaluateHead()
    {
        if (headFill.GetFillAmount() >= headThreshold && !headReadyToRinse)
        {
            headReadyToRinse = true;
            Debug.Log("HEAD READY TO RINSE");
        }

        if (headReadyToRinse && !headClean && headFill.GetFillAmount() <= headCleanValue)
        {
            headClean = true;
            charTextures[0].Clear();
            Debug.Log("HEAD IS NOW CLEAN");
        }
    }

    public void EvaluateLeftArm()
    {
        if (leftArmFill.GetFillAmount() >= leftArmThreshold && !leftArmReadyToRinse)
        {
            leftArmReadyToRinse = true;
            Debug.Log("LEFT ARM READY TO RINSE");
        }

        if (leftArmReadyToRinse && !leftArmClean && leftArmFill.GetFillAmount() <= leftArmCleanValue)
        {
            leftArmClean = true;
            charTextures[1].Clear();
            Debug.Log("LEFT ARM IS NOW CLEAN");
        }
    }

    public void EvaluateRightArm()
    {
        if (rightArmFill.GetFillAmount() >= rightArmThreshold && !rightArmReadyToRinse)
        {
            rightArmReadyToRinse = true;
            Debug.Log("RIGHT ARM TO RINSE");
        }

        if (rightArmReadyToRinse && !rightArmClean && rightArmFill.GetFillAmount() <= rightArmCleanValue)
        {
            rightArmClean = true;
            charTextures[2].Clear();
            Debug.Log("righT ARM IS NOW CLEAN");
        }
    }
}
