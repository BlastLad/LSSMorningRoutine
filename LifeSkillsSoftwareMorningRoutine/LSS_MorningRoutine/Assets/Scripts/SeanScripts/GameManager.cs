using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    [SerializeField]
    GameObject[] checkedBoxes;

    

    public bool boy = true;
    public bool madeBreakfast;
    public bool isDressed;
    public bool brushedTeeth;
    public bool isShowered;

    [SerializeField]
    Text PreReqText;
    [SerializeField]
    GameObject preReqgo;

    [SerializeField]
    GameObject endScreen;

    [SerializeField]
    PlayerMovement player;

    [SerializeField]
    CinemachineVirtualCamera inputCam;

    private void Awake()
    {
        instance = this;
        PlayerStats.isBoy = boy;
        madeBreakfast = PlayerStats.madeBreakfast;
        isDressed = PlayerStats.isDressed;
        brushedTeeth = PlayerStats.brushedTeeth;
        isShowered = PlayerStats.isShowered;

        bool[] stats = new bool[5];

        stats[0] = false;
        stats[1] = isDressed;
        stats[2] = madeBreakfast;
        stats[3] = brushedTeeth;
        stats[4] = isShowered;

        for (int i = 0; i < checkedBoxes.Length; i++)
        {
            checkedBoxes[i].SetActive(stats[i]);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject[] GetCheckedObjects()
    {
        return checkedBoxes;
    }

    public void SetPreReqText(string text)
    {
        PreReqText.text = text;
        preReqgo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowResults()
    {
        endScreen.SetActive(true);
        player.enabled = false;
        inputCam.enabled = false;
        Cursor.lockState = CursorLockMode.None;

    }
}
