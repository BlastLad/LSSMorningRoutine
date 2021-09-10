using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
public class HeatGameManager : MonoBehaviour, MicroGameInterface
{
    [SerializeField]
    CinemachineVirtualCamera heatCam;


    PlayerControls heatControls;
    bool isAdding = false;
    [SerializeField]
    HeatBar heatBar;

    float fillSpeed = 10;
    float drainSpeed = 10;

    [SerializeField]
    GameObject[] requiredGameObjects;//Things needed for the micro game

    [SerializeField]
    GameObject heatTutorial;

    private void Awake()
    {

        heatControls = new PlayerControls();

        heatControls.HeatMicroGame.HeatUp.started += ctx => StartHeatUp();
        heatControls.HeatMicroGame.HeatUp.canceled += ctx => EndHeatUp();
    }

    // Start is called before the first frame update
    void Start()
    {
        heatCam.Priority = 11;
        CookingMinigameManager.instance.SetCurrentCam(heatCam);
    }

    public HeatBar getHeatBar()
    {
        return heatBar;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isAdding)//if the player has the button pressed
        {
            heatBar.ChangeValue(fillSpeed * Time.deltaTime);
        }
        else// if the player does not have the button pressed
        {
            heatBar.ChangeValue(-drainSpeed * Time.deltaTime);
        }
    }


    public void StartHeatUp()//The button press
    {

        float waitVal = Random.Range(0, 0.5f);
        fillSpeed = Random.Range(15f, 45f);

        StartCoroutine(RandomDelay(waitVal));
    }


    private IEnumerator RandomDelay(float timeToWait)//Random delay for the button press
    {
        yield return new WaitForSeconds(timeToWait);
        Debug.Log("REACHED");
        isAdding = true;

    }

    public void EndHeatUp()//What ends the button press
    {
        StopAllCoroutines();
        isAdding = false;
        drainSpeed = Random.Range(30f, 60f);
        Debug.Log("REACHED end: " + isAdding);

    }

    private void OnEnable()
    {
        heatControls.Enable();
    }

    private void OnDisable()
    {
        heatControls.Disable();
    }

    public void ActivateGame()//What starts the heat microgame
    {
        foreach (GameObject preReq in requiredGameObjects)
        {
            preReq.SetActive(true);
        }

        heatTutorial.SetActive(true);
        AudioManager.instance.Play("Paper");


    }

    public void StartGameFromButton()
    {

        CookingMinigameManager.instance.GetCurrentRecipe().GetHeatMicroGameObject().SetActive(true);
        AudioManager.instance.Play("Pop");
    }

    public void DeactivateGame()//What ends the microgame
    {
        CookingMinigameManager.instance.GetCurrentRecipe().GetHeatMicroGameObject().SetActive(false);

        foreach (GameObject preReq in requiredGameObjects)
        {
            preReq.SetActive(false);
        }
    }
}
