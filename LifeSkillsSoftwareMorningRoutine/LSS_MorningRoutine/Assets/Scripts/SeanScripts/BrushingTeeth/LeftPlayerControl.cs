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
            if (addPoints)
            {
                Debug.Log("POINTS ADDED left");
            }
            MusicNote note = leftNotes[0];

            leftNotes.RemoveAt(0);
            Destroy(note.gameObject);

        }
    }

}
