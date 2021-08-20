using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    public static Conductor instance { get; private set; }

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
    NoteCore[] notes;//The positions-in-beats of the notes in the song

    public NoteCore thing;

    //index of next note to spawn
    int index = 0;

    int beatsShownInAdvance = 3;

    [SerializeField]
    GameObject notePrefab;

    [SerializeField]
    Transform leftRemovePos;

    [SerializeField]
    Transform rightRemovePos;

    bool songOver = false;


    bool isPlaying = false;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {


        //Start the music
    }

    public void StartMusic()
    {
        //Load the AudioSource attached to the Conductor GameObject
        musicSource = GetComponent<AudioSource>();

        //Calculate the number of seconds in each beat
        secPerBeat = 60f / songBpm;

        //Record the time when the music starts
        dspSongTime = (float)AudioSettings.dspTime;

        isPlaying = true;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            //determine how many seconds since the song started
            songPosition = (float)(AudioSettings.dspTime - dspSongTime);

            //determine how many beats since the song started
            songPositionInBeats = songPosition / secPerBeat + 1;

            if (index < notes.Length && notes[index].beat < songPositionInBeats + beatsShownInAdvance)
            {
                GameObject note = Instantiate(notePrefab, transform.position, Quaternion.identity);

                //Debug.Log(notes[index].name + " " + notes[index].isHold);

                Vector3 movePos;

                if (notes[index].moveLeft)
                {
                    movePos = leftRemovePos.position;
                }
                else
                {
                    movePos = rightRemovePos.position;
                }


                if (notes[index].isHold)
                {
                    note.GetComponent<MusicNote>().SetUp(transform.position, movePos, beatsShownInAdvance, songPositionInBeats, notes[index].beat, notes[index].holdNoteLength);
                }
                else
                {
                    note.GetComponent<MusicNote>().SetUp(transform.position, movePos, beatsShownInAdvance, songPositionInBeats, notes[index].beat);
                }
                //initialize the fields of the music note

                index++;
            }
            else
            {
                if (index >= notes.Length && !songOver)
                {
                    songOver = true;
                    StartCoroutine(enableEndScreen());
                }
                //song is over
            }
        }

    }

    private IEnumerator enableEndScreen()
    {
        yield return new WaitForSeconds(4f);//might need to change
        BrushingTeethGameManager.instance.EnableEndScreen();
    }

    public GameObject SpawnHoldNoteEnd(GameObject prefab)
    {
        return Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
