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

    private void Awake()
    {
       
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetUp(Vector2 spawnPos, Vector2 removePos, int advanceNotes, float songPosBeats, float currentBeat)
    {
        SpawnPos = spawnPos;
        RemovePos = removePos;
        BeatsShownInAdvance = advanceNotes;
        songPosInBeats = songPosBeats;
        beatOfThisNote = currentBeat;
    }

    // Update is called once per frame
    void Update()
    {
        songPosInBeats = Conductor.instance.songPositionInBeats;

        transform.position = Vector2.Lerp(
       SpawnPos,
       RemovePos,
       (BeatsShownInAdvance - (beatOfThisNote - songPosInBeats)) / BeatsShownInAdvance);
   
    }
}
