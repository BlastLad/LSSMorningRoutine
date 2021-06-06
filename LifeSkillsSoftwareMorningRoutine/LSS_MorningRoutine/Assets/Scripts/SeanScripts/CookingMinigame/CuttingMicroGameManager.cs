using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CuttingMicroGameManager : MonoBehaviour
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
        }
        else
        {
            sideCam.Priority = 10;
            frontCam.Priority = 9;
        }

        playerKnife.SetFrontCam(toFront);
        nextPointController.ChangeArrow(toFront);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
