using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LeftPlayerControl : MonoBehaviour
{
    [SerializeField]
    List<MusicNote> leftNotes = new List<MusicNote>();

    [SerializeField]
    List<MusicNote> leftHolds = new List<MusicNote>();

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
        if (leftHolds.Count > 0)
        {
            if (BrushingTeethPlayerController.instance.GetLeftStatus() && !holdMissed)
            {               
                int newBeat = (int)Conductor.instance.songPositionInBeats;

                if (newBeat != previousBeat) {
                    BrushingTeethGameManager.instance.AddToScore(100);
                    previousBeat = newBeat;
                }
                //add points based on conductor???
            }
        }
    }

    public List<MusicNote> GetLeftHolds()
    {
        return leftHolds;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Note"))
        {
            leftNotes.Add(other.gameObject.GetComponent<MusicNote>());
        }
    }

    public void destroyNote(bool addPoints)
    {
        if (leftNotes.Count > 0)
        {
            if (leftNotes[0] == null)
            {
                Debug.LogWarning("SAFTEY CHECK");
                leftNotes.RemoveAt(0);
                return;
            }
            MusicNote note = leftNotes[0];

            if (note.getisHold())
            {                
                //check if hold is active
                Debug.Log("HOLD NOTE" + leftNotes[0].name);
                leftHolds.Add(leftNotes[0]);
                leftNotes.RemoveAt(0);      
                
                if (!addPoints)// if you missed the beat
                {
                    holdMissed = true;
                    note.gameObject.GetComponent<LineRenderer>().startColor = Color.gray;
                    note.gameObject.GetComponent<LineRenderer>().endColor = Color.gray;
                }
                else
                {
                    note.speed = 0;
                    holdMissed = false;
                    BrushingTeethPlayerController.instance.leftHoldActive = true;
                    note.gameObject.GetComponent<LineRenderer>().startColor = Color.blue;
                    note.gameObject.GetComponent<LineRenderer>().endColor = Color.blue;
                }


                return;
                //removefrom thing put into a holdnote arraylist
                //return
            }

            if (addPoints)
            {

                float distance = Vector2.Distance(transform.position, note.transform.position);

                if (distance > 1.19) {

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

                BrushingTeethGameManager.instance.MoveLeft();


                
            }
            else//indicates a missed note
            {
                BrushingTeethGameManager.instance.ResetComboMod();
            }
            

            leftNotes.RemoveAt(0);
            Destroy(note.gameObject);

        }
    }

    public void destroyNote(bool addPoints, GameObject endHold)
    {
        if (leftHolds.Count > 0)
        {
            MusicNote note = leftHolds[0];
            Debug.Log("IS IT A HOLD NOTE" + leftHolds[0].name);
          
            if (addPoints && !holdMissed && endHold != null)
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

                Debug.Log("POINTS ADDED left");
            }
            else//indicates a missed note
            {
                BrushingTeethGameManager.instance.ResetComboMod();
            }

            BrushingTeethPlayerController.instance.leftHoldActive = false;
            holdMissed = true;
            leftHolds.RemoveAt(0);
            Destroy(note.gameObject);
            if (leftNotes.Count > 0)
            {
                leftNotes.RemoveAt(0);//end note
            }
            if (endHold != null)
            {
          
                Destroy(endHold.gameObject);
            }

        }
    }

}
