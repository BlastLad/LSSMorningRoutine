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
    int maxCombo = 0;

    [SerializeField]
    Text comboText;
    [SerializeField]
    Text scoretext;
    [SerializeField]
    GameObject stateText;
    [SerializeField]
    Transform stateTextSpawnPos;
    [SerializeField]
    Canvas canvasObj;

    [SerializeField]
    GameObject toothBrush;
    [SerializeField]
    List<Transform> toothBrushTopPos;
    [SerializeField]
    List<Transform> toothBrushBotPos;

    Transform startPos;
    Transform endPos;

    [SerializeField]
    GameObject particleEffect;

    [SerializeField]
    GameObject endScreen;
    [SerializeField]
    Text endScreenScore;
    [SerializeField]
    Text endScreenMaxCombo;

    bool isMoving = false;
    float speed = 4f;
    int toothIndex = 0;
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
        if (isMoving)
        {
            Vector3 direction = endPos.position - toothBrush.transform.position;

            toothBrush.transform.Translate(direction.normalized * speed * Time.deltaTime);

            //Debug.Log(Vector3.Distance(toothBrush.transform.position, endPos.position) + endPos.name);
            if (Vector3.Distance(toothBrush.transform.position, endPos.position) < 0.2f)
            {
                ///particleeffect on location
                GameObject particle = Instantiate(particleEffect, endPos.position, Quaternion.identity, endPos);
                isMoving = false;
            }

        }
    }

    public void MoveLeft()
    {
        startPos = toothBrushTopPos[toothIndex];

        if (toothIndex > 0)
        {
            toothIndex--;
            speed = 4f;
        }
        else
        {
            toothIndex = toothBrushTopPos.Count - 1;
            speed = 7f;
        }
        if (!isMoving)
        {
            endPos = toothBrushTopPos[toothIndex];

            isMoving = true;
        }
    }

    public void MoveRight()
    {
        startPos = toothBrushBotPos[toothIndex];

        if (toothIndex < toothBrushBotPos.Count - 1)
        {
            toothIndex++;
            speed = 4f;
        }
        else
        {
            toothIndex = 0;
            speed = 7f;
        }

        if (!isMoving)
        {
            endPos = toothBrushBotPos[toothIndex];

            isMoving = true;
        }
    }
    
    public void SpawnStateText(string text, int size)
    {
        GameObject spawnedText = Instantiate(stateText, stateTextSpawnPos.position, Quaternion.identity, canvasObj.transform);

        spawnedText.GetComponent<StateTextCore>().SetStateText(text, size);
    }

    public void AddToScore(int value)
    {
        combo++;

        if (combo > maxCombo)
        {
            maxCombo = combo;
        }

        comboText.text = "" + combo + " Beat";
        comboText.transform.parent.gameObject.SetActive(true);


        if (combo >= 30)
        {
            comboText.fontSize = 35;
            comboMod = 3f;
        }        
        else if (combo >= 25)
        {
            comboText.fontSize = 25;
            comboMod = 2f;
        }
        else if (combo >= 15)
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

        comboText.text = "" + combo + " Beat";
        comboText.fontSize = 20;
        comboText.transform.parent.gameObject.SetActive(false);

    }


    public void EnableEndScreen()
    {
        endScreen.SetActive(true);
        endScreenScore.text = "" + points;
        endScreenMaxCombo.text = "" + maxCombo;

        
    }

    public void ReturnToMain()
    {
        PlayerStats.brushedTeeth = true;
        SceneManager.LoadScene(0);
    }
}

