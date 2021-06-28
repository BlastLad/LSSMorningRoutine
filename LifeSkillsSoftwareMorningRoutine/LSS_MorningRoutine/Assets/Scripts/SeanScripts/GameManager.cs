using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    [SerializeField]
    GameObject[] checkedBoxes;

    

    public bool boy = true;
    public bool madeBreakfast;
    public bool isDressed;

    private void Awake()
    {
        instance = this;
        PlayerStats.isBoy = boy;
        madeBreakfast = PlayerStats.madeBreakfast;
        isDressed = PlayerStats.isDressed;

        bool[] stats = new bool[4];

        stats[0] = false;
        stats[1] = isDressed;
        stats[2] = madeBreakfast;
        stats[3] = false;

        for (int i = 0; i < checkedBoxes.Length; i++)
        {
            checkedBoxes[i].SetActive(stats[i]);
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
}
