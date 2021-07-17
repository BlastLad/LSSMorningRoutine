using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNote : MonoBehaviour
{
    public Vector2 SpawnPos;
    public Vector2 RemovePos;
    public int BeatsShownInAdvance;
    public float songPosInBeats;
    public float beatOfThisNote;

    float holdNoteLength;
    public float holdNoteEndBeat;
    bool isHold = false;
    [SerializeField]
    GameObject holdNoteEndPrefab;
    public GameObject endNote;

    [SerializeField]
    Material defaultMat;

    bool movingToHitPos = true;
    bool endMovingToHitPos = true;
    public float speed = 8;
    bool holdSpawned = false;

    LineRenderer lineRenderer;
    private void Awake()
    {
       
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetMovingToHit(bool val)
    {
        movingToHitPos = val;
    }

    public void SetEndMovingToHit(bool val)
    {
        endMovingToHitPos = val;
    }

    public bool GetMovingToHit(bool val)
    {
        return movingToHitPos;
    }

    public void SetUp(Vector2 spawnPos, Vector2 removePos, int advanceNotes, float songPosBeats, float currentBeat)
    {
        SpawnPos = spawnPos;
        RemovePos = removePos;
        BeatsShownInAdvance = advanceNotes;
        songPosInBeats = songPosBeats;
        beatOfThisNote = currentBeat;
    }

    public void SetUp(Vector2 spawnPos, Vector2 removePos, int advanceNotes, float songPosBeats, float currentBeat, float endHold)
    {
        SpawnPos = spawnPos;
        RemovePos = removePos;
        BeatsShownInAdvance = advanceNotes;
        songPosInBeats = songPosBeats;
        beatOfThisNote = currentBeat;
        holdNoteLength = endHold - currentBeat;
        holdNoteEndBeat = currentBeat + holdNoteLength;
        isHold = true;

        SpawnLineRenderer();
    }

    public void SpawnLineRenderer()
    {
        gameObject.AddComponent<LineRenderer>();
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.material = defaultMat;
        lineRenderer.startColor = Color.white;
        lineRenderer.endColor = Color.blue;

        lineRenderer.useWorldSpace = true;

    }

    public bool getisHold()
    {
        bool temp = isHold;
        //isHold = 
        return isHold;
    }
    // Update is called once per frame
    void Update()
    {
        songPosInBeats = Conductor.instance.songPositionInBeats;

        if (movingToHitPos)
        {
            transform.position = Vector2.Lerp(
           SpawnPos,
           RemovePos,
           (BeatsShownInAdvance - (beatOfThisNote - songPosInBeats)) / BeatsShownInAdvance);
        }
        else
        {
            transform.position += (Vector3)(RemovePos.normalized * speed * Time.deltaTime);
        }

        if (isHold)
        {
            //Debug.Log(songPosInBeats + " " + (holdNoteEndBeat - BeatsShownInAdvance));

            
            //

            if ((int)songPosInBeats ==  holdNoteEndBeat - BeatsShownInAdvance && holdSpawned == false)
            {
                Debug.Log("REACHED");
                endNote = Conductor.instance.SpawnHoldNoteEnd(holdNoteEndPrefab);
                endNote.GetComponent<EndHold>().SetParentHold(this);
                holdSpawned = true;
            }
            if (endNote != null)
            {
                if (endMovingToHitPos)
                {
                    endNote.transform.position = Vector2.Lerp(SpawnPos, RemovePos, (BeatsShownInAdvance - (holdNoteEndBeat - songPosInBeats)) / BeatsShownInAdvance);
                }
                else
                {
                    endNote.transform.position += (Vector3)(RemovePos.normalized * 8 * Time.deltaTime);
                }
                lineRenderer.SetPosition(0, transform.position);
                lineRenderer.SetPosition(1, endNote.transform.position);
            }
            else
            {
                lineRenderer.SetPosition(0, transform.position);
                lineRenderer.SetPosition(1, Conductor.instance.transform.position);
            }
        }
   
    }
}
