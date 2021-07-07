using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayerControl : MonoBehaviour
{
    [SerializeField]
    List<MusicNote> leftNotes = new List<MusicNote>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            MusicNote note = leftNotes[0];

            if (addPoints)
            {
                float distance = Vector2.Distance(transform.position, note.transform.position);

                if (distance > 0.39f)
                {
                    BrushingTeethGameManager.instance.AddToScore(100);
                    Debug.Log("ok");
                }
                else if (distance > 0.19)
                {
                    BrushingTeethGameManager.instance.AddToScore(250);
                    Debug.Log("good");                    
                }
                else
                {
                    BrushingTeethGameManager.instance.AddToScore(500);
                    Debug.Log("PERFECT");
                }

                Debug.Log("POINTS ADDED left");
            }
            else//indicates a missed note
            {
                BrushingTeethGameManager.instance.ResetComboMod();
            }
            

            leftNotes.RemoveAt(0);
            Destroy(note.gameObject);

        }
    }

}
