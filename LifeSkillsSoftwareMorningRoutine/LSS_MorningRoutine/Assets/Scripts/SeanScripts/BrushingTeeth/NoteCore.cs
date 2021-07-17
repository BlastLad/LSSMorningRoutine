using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class NoteCore
{
    public string name;
    public float beat;
    public bool moveLeft;
    public bool isHold;
    public float holdNoteLength;

    public void SetNoteName(string abc)
    {
        name = abc;
    }
}
