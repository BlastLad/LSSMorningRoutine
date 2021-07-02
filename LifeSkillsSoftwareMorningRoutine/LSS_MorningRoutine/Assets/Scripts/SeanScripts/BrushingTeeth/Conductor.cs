using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    //Song beats per minute
    //This is determined by the song you're trying to sync up to
    public float songBpm;

    //The number of seconds for each song beat
    public float secPerBeat;

    //Current song position, in seconds
    public float songPosition;

    //Current song position, in beats
    public float songPositionInBeats;

    //How many seconds have passed since the song started
    public float dspSongTime;

    //an AudioSource attached to this GameObject that will play the music.
    public AudioSource musicSource;

    [SerializeField]
    float[] notes;//The positions-in-beats of the notes in the song

    //index of next note to spawn
    int index = 0;

    int beatsShownInAdvance = 3;

    [SerializeField]
    GameObject notePrefab;

    [SerializeField]
    Transform leftRemovePos;

    [SerializeField]
    Transform rightRemovePos;

    // Start is called before the first frame update
    void Start()
    {
        //Load the AudioSource attached to the Conductor GameObject
        musicSource = GetComponent<AudioSource>();

        //Calculate the number of seconds in each beat
        secPerBeat = 60f / songBpm;

        //Record the time when the music starts
        dspSongTime = (float)AudioSettings.dspTime;

        //Start the music
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //determine how many seconds since the song started
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);

        //determine how many beats since the song started
        songPositionInBeats = songPosition / secPerBeat;

        if (index < notes.Length && notes[index] < songPositionInBeats + beatsShownInAdvance)
        {
            GameObject note = Instantiate(notePrefab, transform.position, Quaternion.identity);

            note.GetComponent<MusicNote>().SetUp(leftRemovePos.position, beatsShownInAdvance, songPositionInBeats, notes[index]);
            //initialize the fields of the music note

            index++;
        }

    }
}