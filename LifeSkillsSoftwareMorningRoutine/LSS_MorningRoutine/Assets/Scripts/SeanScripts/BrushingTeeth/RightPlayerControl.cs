using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayerControl : MonoBehaviour
{
    [SerializeField]
    List<MusicNote> rightNotes = new List<MusicNote>();
    List<MusicNote> rightHolds = new List<MusicNote>();


    [SerializeField]
    GameObject particleEffect;
    [SerializeField]
    Transform spawnPos;
    [SerializeField]
    Canvas canvas;


    int previousBeat = 0;
    bool holdMissed = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rightHolds.Count > 0)
        {
            if (BrushingTeethPlayerController.instance.GetRightStatus() && !holdMissed)
            {
                int newBeat = (int)Conductor.instance.songPositionInBeats;

                if (newBeat != previousBeat)
                {
                    BrushingTeethGameManager.instance.AddToScore(100);
                    previousBeat = newBeat;
                }
                //add points based on conductor???
            }
        }

    }

    public List<MusicNote> GetRightHolds()
    {
        return rightHolds;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Note"))
        {
            rightNotes.Add(other.gameObject.GetComponent<MusicNote>());
        }
    }

    public void destroyNote(bool addPoints)
    {
    

        if (rightNotes.Count > 0)
        {

            MusicNote note = rightNotes[0];

            if (note.getisHold())
            {
                Debug.Log("HOLD NOTE");
                rightHolds.Add(rightNotes[0]);
                rightNotes.RemoveAt(0);

                if (!addPoints)// if you missed the beat
                {
                    holdMissed = true;
                    note.gameObject.GetComponent<LineRenderer>().startColor = Color.gray;
                    note.gameObject.GetComponent<LineRenderer>().endColor = Color.gray;
                }
                else
                {
                    holdMissed = false;
                    BrushingTeethPlayerController.instance.rightHoldActive = true;
                    note.gameObject.GetComponent<LineRenderer>().startColor = Color.blue;
                    note.gameObject.GetComponent<LineRenderer>().endColor = Color.blue;
                }

                note.speed = 0;

                return;
                //removefrom thing put into a holdnote arraylist
                //return
            }

            if (addPoints)
            {
                float distance = Vector2.Distance(transform.position, note.transform.position);

                if (distance > 1.19)
                {
                    BrushingTeethGameManager.instance.AddToScore(10);
                    BrushingTeethGameManager.instance.SpawnStateText("Bad", 30);
                }
                else if (distance > 0.69f)
                {
                    BrushingTeethGameManager.instance.AddToScore(100);
                    BrushingTeethGameManager.instance.SpawnStateText("Good", 40);
                }
                else if (distance > 0.29)
                {
                    BrushingTeethGameManager.instance.AddToScore(250);
                    BrushingTeethGameManager.instance.SpawnStateText("Great", 45);
                }
                else
                {
                    BrushingTeethGameManager.instance.AddToScore(500);
                    BrushingTeethGameManager.instance.SpawnStateText("Perfect", 52);
                }

                Debug.Log("POINTS ADDED RIGHT");
            }
            else//indicates a missed note
            {
                BrushingTeethGameManager.instance.ResetComboMod();
            }

            rightNotes.RemoveAt(0);

            Destroy(note.gameObject);
        }
    }

    public void destroyNote(bool addPoints, GameObject endHold)
    {
        if (rightHolds.Count > 0)
        {
            MusicNote note = rightHolds[0];

            if (addPoints && !holdMissed)
            {
                float distance = Vector2.Distance(transform.position, endHold.transform.position);

                if (distance > 1.19f)
                {
                    BrushingTeethGameManager.instance.AddToScore(10);
                    BrushingTeethGameManager.instance.SpawnStateText("Bad", 30);
                }
                else if (distance > 0.69f)
                {
                    BrushingTeethGameManager.instance.AddToScore(100);
                    BrushingTeethGameManager.instance.SpawnStateText("Good", 40);
                }
                else if (distance > 0.29)
                {
                    BrushingTeethGameManager.instance.AddToScore(250);
                    BrushingTeethGameManager.instance.SpawnStateText("Great", 45);
                }
                else
                {
                    BrushingTeethGameManager.instance.AddToScore(500);
                    BrushingTeethGameManager.instance.SpawnStateText("Perfect", 52);
                }

                GameObject particle = Instantiate(particleEffect, spawnPos.position, Quaternion.identity, canvas.transform);
                particle.SetActive(false);
                particle.SetActive(true);
            }
            else//indicates a missed note
            {
                BrushingTeethGameManager.instance.ResetComboMod();
            }

            BrushingTeethPlayerController.instance.rightHoldActive = false;
            holdMissed = true;
            rightHolds.RemoveAt(0);
            Destroy(note.gameObject);
            Destroy(endHold.gameObject);

        }
    }
}
