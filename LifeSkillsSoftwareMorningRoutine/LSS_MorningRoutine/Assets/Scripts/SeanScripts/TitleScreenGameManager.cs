using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TitleScreenGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Outline girlOutLine;
    public Outline BoyOutLine;
    bool boyHighlighted = false;
    bool girlHighlighted = false;
    PlayerControls controls;



    private void Awake()
    {
        controls = new PlayerControls();

        controls.Title.Select.performed += ctx => evaluateSelection();
    }
    void Start()
    {
        PlayerStats.brushedTeeth = false;
        PlayerStats.isDressed = false;
        PlayerStats.isShowered = false;
        PlayerStats.madeBreakfast = false;
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.tag == "Girl")
            {
                girlOutLine.enabled = true;
                girlHighlighted = true;
            }
            else if (hit.transform.gameObject.tag == "Boy")
            {
                BoyOutLine.enabled = true;
                boyHighlighted = true;
            }
            else if (hit.transform.gameObject.tag == "Untagged")
            {
                girlOutLine.enabled = false;
                BoyOutLine.enabled = false;
                boyHighlighted = false;
                girlHighlighted = false;
            }
        }
   
    }


    public void evaluateSelection()
    {
        Debug.Log("PERFORMED");
        if (girlHighlighted)
        {
            SetGirl();
            StartGame();
        }
        else if (boyHighlighted)
        {
            SetBoy();
            StartGame();
        }
    }

    public void SetGirl()
    {
        PlayerStats.isBoy = false;
    }

    public void SetBoy()
    {
        PlayerStats.isBoy = true;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(5);
    }
}
