using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CuttingMicroGameManager : MonoBehaviour, MicroGameInterface
{
    public static CuttingMicroGameManager instance { get; private set;}

    [SerializeField]
    CinemachineVirtualCamera frontCam;
    [SerializeField]
    CinemachineVirtualCamera sideCam;

    [SerializeField]
    KnifeSkills playerKnife;
    [SerializeField]
    NextPointController nextPointController;

    [SerializeField]
    GameObject[] requiredGameObjects;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void ChangeCamera(bool toFront)
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
