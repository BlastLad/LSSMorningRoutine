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
    GameObject[] requiredGameObjects;

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
        if (isAdding)
        {
            heatBar.ChangeValue(fillSpeed * Time.deltaTime);
        }
        else
        {
            heatBar.ChangeValue(-drainSpeed * Time.deltaTime);
        }
    }


    public void StartHeatUp()
    {

        float waitVal = Random.Range(0, 0.7f);
        fillSpeed = Random.Range(15f, 45f);

        StartCoroutine(RandomDelay(waitVal));
    }


    private IEnumerator RandomDelay(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        Debug.Log("REACHED");
        isAdding = true;

    }

    public void EndHeatUp()
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

    public void ActivateGame()
    {
        foreach (GameObject preReq in requiredGameObjects)
        {
            preReq.SetActive(true);
        }
    }

    public void DeactivateGame()
    {
        foreach (GameObject preReq in requiredGameObjects)
        {
            preReq.SetActive(false);
        }
    }
}
