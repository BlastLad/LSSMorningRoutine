using UnityEngine.Audio;
using UnityEngine;


[System.Serializable]
public class Sound {

    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(-12f, 12f)]
    public float pitch;
    public bool loop;
    public int TimesPlayed = 0;
    
    public AudioSource source;
}
