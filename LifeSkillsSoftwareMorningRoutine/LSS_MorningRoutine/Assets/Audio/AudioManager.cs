using UnityEngine.Audio;
using System;
using UnityEngine;



public class AudioManager : MonoBehaviour {
    public static AudioManager instance
    {
        get;
        private set;
    }
    public Sound[] Sounds;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else Debug.Log("Warning: Multible Instances!!!");
        foreach (Sound s in Sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.name == name);
        s.source.Play();
        Debug.Log("Fired lol" + name);

    }
    public void PlaySoundInterval(float from, float to, string name)
    {
        Debug.Log("Fired lol");
        Sound s = Array.Find(Sounds, sound => sound.name == name);
        s.source.time = from;
        s.source.Play();
        s.source.SetScheduledEndTime(AudioSettings.dspTime + (to - from));
        s.TimesPlayed++;

    }
    public void PlaySoundIntervalToEnd(float from, string name)
    {

        Sound s = Array.Find(Sounds, sound => sound.name == name);
        s.source.time = from;
        s.source.Play();
        s.source.SetScheduledEndTime(AudioSettings.dspTime + (s.clip.length - from));
        Debug.Log("Fired lol" + s.source.isPlaying + " " + s.source.time + name);
        s.TimesPlayed++;
    }

    public Sound GetSound(string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.name == name);
        return s;
    }

    public void StopSound(string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.name == name);
        s.source.Stop();
    }

    public int GetTimesPlayed(string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.name == name);
        return s.TimesPlayed;
    }
    
    public void setTimesPlayed(int t, string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.name == name);

        s.TimesPlayed = t;
    }

    public Boolean isPlaying(string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.name == name);
        return s.source.isPlaying;
    }

    public void RaisePitch(string name, float amt)
    {
        Sound s = Array.Find(Sounds, sound => sound.name == name);
        s.pitch = s.pitch + amt;
    }

    public void LowerPitch(string name, float amt)
    {
        Sound s = Array.Find(Sounds, sound => sound.name == name);
        s.pitch = s.pitch - amt;
    }
}