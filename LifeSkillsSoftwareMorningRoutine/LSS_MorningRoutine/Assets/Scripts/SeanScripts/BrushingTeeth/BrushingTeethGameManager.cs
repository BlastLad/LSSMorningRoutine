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

            Debug.Log(Vector3.Distance(toothBrush.transform.position, endPos.position) + endPos.name);
            if (Vector3.Distance(toothBrush.transform.position, endPos.position) < 0.2f)
            {
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

        endPos = toothBrushTopPos[toothIndex];

        isMoving = true;
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

        endPos = toothBrushBotPos[toothIndex];

        isMoving = true;
    }
    
    public void SpawnStateText(string text, int size)
    {
        GameObject spawnedText = Instantiate(stateText, stateTextSpawnPos.position, Quaternion.identity, canvasObj.transform);

        spawnedText.GetComponent<StateTextCore>().SetStateText(text, size);
    }

    public void AddToScore(int value)
    {
        combo++;

        comboText.text = "" + combo + " Beat";
        
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

        comboText.text = "" + combo + " Beat";

    }
}

