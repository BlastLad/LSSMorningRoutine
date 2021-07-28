using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class EggMicroGameController : MonoBehaviour, MicroGameInterface
{
    public static EggMicroGameController instance { get; private set; }

    public PlayerControls eggControls;

    public int requiredEggs;
    [SerializeField]
    Text eggText;
    public int currentEggs;

    int eggsSpawned;

    [SerializeField]
    Transform eggSpawnLocation;
    [SerializeField]
    GameObject eggPreFab;

    [SerializeField]
    GameObject hitImage;
    [SerializeField]
    GameObject crackImage;
    [SerializeField]
    GameObject grabImage;


    DragRigidbody currentEgg;

    [SerializeField]
    GameObject[] requiredGameObjects;
    [SerializeField]
    CinemachineVirtualCamera eggCam;

    [SerializeField]
    GameObject eggTutorial;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        eggControls = new PlayerControls();


        eggControls.MixingMicroGame.Grab.started += ctx => HandleInputBegin();
        eggControls.MixingMicroGame.Grab.canceled += ctx => HandleInputEnd();
        eggControls.MixingMicroGame.Crack.started += ctx => CrackEgg();

        eggText.text = "" + requiredEggs;
    }

    public void EnableCrackImage()
    {
        crackImage.SetActive(true);
        hitImage.SetActive(false);
        grabImage.SetActive(false);
    }

    void HandleInputBegin()
    {
        if (currentEgg != null)
        {
            currentEgg.HandleInputBegin();
        }
    }

    public void enableHitImage()
    {
        hitImage.SetActive(true);
        crackImage.SetActive(false);
        grabImage.SetActive(false);
    }

    void HandleInputEnd()
    {
        if (currentEgg != null)
        {
            currentEgg.HandleInputEnd();
        }
    }

    void CrackEgg()
    {
        currentEgg.CrackEgg();
        AudioManager.instance.Play("Crack");
        
    }

    public void ActivateGame()
    {
        CookingMinigameManager.instance.SetCurrentCam(eggCam);
        foreach (GameObject preReq in requiredGameObjects)
        {
            preReq.SetActive(true);
        }

        eggTutorial.SetActive(true);

    }

    public void StartFromButton()
    {
        SpawnNewEgg();
    }

    public void DeactivateGame()
    {
        Destroy(currentEgg.gameObject);
        foreach (GameObject preReq in requiredGameObjects)
        {
            preReq.SetActive(false);
        }
    }

    public void AddEgg()
    {
        currentEggs++;
        eggText.text = "" + (requiredEggs - currentEggs);
        //soundeffect
        //particleEffect
        if (currentEggs >= requiredEggs)
        {
            Debug.Log("Congratulationus");
            if (eggsSpawned - requiredEggs < 0)
            {
                CookingMinigameManager.instance.fillableField[CookingMinigameManager.instance.index].text = "0";

            }
            else
            {
                CookingMinigameManager.instance.fillableField[CookingMinigameManager.instance.index].text = "" + (eggsSpawned - requiredEggs - 1);
            }
            CookingMinigameManager.instance.GetNextMicrogame();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnNewEgg()
    {
        eggsSpawned++;
        GameObject newEgg = Instantiate(eggPreFab, eggSpawnLocation.position, Quaternion.identity, transform);
        currentEgg = newEgg.GetComponent<DragRigidbody>();
        crackImage.SetActive(false);
        hitImage.SetActive(false);
        grabImage.SetActive(true);
    }

    private void OnEnable()
    {
        eggControls.Enable();
    }

    private void OnDisable()
    {
        eggControls.Disable();
    }
}
