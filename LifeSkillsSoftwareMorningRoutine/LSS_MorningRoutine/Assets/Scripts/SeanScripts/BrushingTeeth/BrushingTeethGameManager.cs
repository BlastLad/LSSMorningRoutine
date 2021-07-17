using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BrushingTeethGameManager : MonoBehaviour
{
    public static BrushingTeethGameManager instance { get; private set; }

    public int points = 0;
    public float comboMod = 1;
    public int combo = 0;

    [SerializeField]
    Text scoretext;
    [SerializeField]
    GameObject stateText;
    [SerializeField]
    Transform stateTextSpawnPos;
    [SerializeField]
    Canvas canvasObj;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SpawnStateText(string text, int size)
    {
        GameObject spawnedText = Instantiate(stateText, stateTextSpawnPos.position, Quaternion.identity, canvasObj.transform);

        spawnedText.GetComponent<StateTextCore>().SetStateText(text, size);
    }

    public void AddToScore(int value)
    {
        combo++;

        
        if (combo >= 30)
        {
            comboMod = 3f;
        }        
        else if (combo >= 20)
        {
            comboMod = 2f;
        }
        else if (combo >= 10)
        {
            comboMod = 1.5f;
        }

        points += (int)(value * comboMod);
        scoretext.text = "" + points;
    }

    public void ResetComboMod()
    {
        combo = 0;
        comboMod = 1;
    }
}

