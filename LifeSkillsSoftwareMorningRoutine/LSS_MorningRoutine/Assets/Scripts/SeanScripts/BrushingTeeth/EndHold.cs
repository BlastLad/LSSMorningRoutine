using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndHold : MonoBehaviour
{

    MusicNote parentHold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetParentHold(MusicNote val)
    {
        parentHold = val;
    }

    public MusicNote GetAttachedGO()
    {
        return parentHold;
    }
}
