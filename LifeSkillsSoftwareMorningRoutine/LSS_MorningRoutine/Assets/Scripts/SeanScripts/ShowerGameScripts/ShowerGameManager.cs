using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerGameManager : MonoBehaviour
{
    public static ShowerGameManager instance { get; private set; }

    bool isBoy;

    [SerializeField]
    GameObject boyObj;
    [SerializeField]
    GameObject girlObj;
 

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
}
