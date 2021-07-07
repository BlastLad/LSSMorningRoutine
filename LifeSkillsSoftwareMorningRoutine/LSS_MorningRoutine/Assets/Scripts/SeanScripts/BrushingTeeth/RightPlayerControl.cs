using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayerControl : MonoBehaviour
{
    [SerializeField]
    List<MusicNote> rightNotes = new List<MusicNote>();

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
            rightNotes.Add(other.gameObject.GetComponent<MusicNote>());
        }
    }

    public void destroyNote(bool addPoints)
    {
    

        if (rightNotes.Count > 0)
        {

            MusicNote note = rightNotes[0];


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
}
