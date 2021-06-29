using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlAudio : MonoBehaviour
{
    AudioSource Bowl;
    void Start()
    {
        Bowl = GetComponent<AudioSource>();

    }
    void OnMouseDown()
    {
        Bowl.PlayOneShot(Bowl.clip);
    }
}
