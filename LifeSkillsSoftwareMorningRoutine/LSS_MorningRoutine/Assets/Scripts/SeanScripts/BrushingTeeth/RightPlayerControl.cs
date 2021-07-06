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
            if (addPoints)
            {
                Debug.Log("POINTS ADDED RIGHT");
            }
            MusicNote note = rightNotes[0];
            rightNotes.RemoveAt(0);

            Destroy(note.gameObject);
        }
    }
}
