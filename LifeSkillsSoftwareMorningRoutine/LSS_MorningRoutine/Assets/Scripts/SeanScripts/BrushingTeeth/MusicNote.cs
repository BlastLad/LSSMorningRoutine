using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicNote : MonoBehaviour
{

    Vector2 SpawnPos;
    Vector2 RemovePos;
    int BeatsShownInAdvance;
    float songPosInBeats;
    float beatOfThisNote;

    private void Awake()
    {
       
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetUp(Vector2 removePos, int advanceNotes, float songPosBeats, float currentBeat)
    {
        SpawnPos = transform.position;
        RemovePos = removePos;
        BeatsShownInAdvance = advanceNotes;
        songPosInBeats = songPosBeats;
        beatOfThisNote = currentBeat;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(
       SpawnPos,
       RemovePos,
       (BeatsShownInAdvance - (beatOfThisNote - songPosInBeats)) / BeatsShownInAdvance
   );
    }
}
