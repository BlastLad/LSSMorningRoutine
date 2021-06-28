using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CuttingMicroGameManager : MonoBehaviour, MicroGameInterface
{
    public static CuttingMicroGameManager instance { get; private set;}

    [SerializeField]
    CinemachineVirtualCamera frontCam;//front camera
    [SerializeField]
    CinemachineVirtualCamera sideCam;// the side view of the camera

    [SerializeField]
    KnifeSkills playerKnife;
    [SerializeField]
    NextPointController nextPointController;

    [SerializeField]
    GameObject[] requiredGameObjects;//things necessary for the cutting micro game

    GameObject[] objectsToCut;
    public int currentCutIndex = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void ChangeCamera(bool toFront)//changes camera between the side and front view
    {
        if (toFront)
        {
            sideCam.Priority = 9;
            frontCam.Priority = 10;
            CookingMinigameManager.instance.SetCurrentCam(frontCam);
        }
        else
        {
            sideCam.Priority = 10;
            frontCam.Priority = 9;
            CookingMinigameManager.instance.SetCurrentCam(sideCam);
        }

        playerKnife.SetFrontCam(toFront);        
        nextPointController.ChangeArrow(toFront);

    }

    // Start is called before the first frame update
    void Start()
    {
            frontCam.Priority = 11;
            CookingMinigameManager.instance.SetCurrentCam(frontCam);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToBread()
    {
        nextPointController.setFoodObject(objectsToCut[1]);
        currentCutIndex = 1;
    }

    public void ActivateGame()//What starts the micro game
    {
        foreach (GameObject preReq in requiredGameObjects)
        {
            preReq.SetActive(true);
        }


        objectsToCut = CookingMinigameManager.instance.GetCurrentRecipe().GetCuttingMicroGameObjects();

        objectsToCut[0].SetActive(true);

        nextPointController.setFoodObject(objectsToCut[0]);
    }

    public void DeactivateGame()//what ends the microgame
    {
        foreach (GameObject preReq in requiredGameObjects)
        {
            preReq.SetActive(false);
        }

        foreach (GameObject item in objectsToCut)
        {
            item.SetActive(false);
        }
    }
}
