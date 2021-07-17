using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissPosBeginMoving : MonoBehaviour
{
    string musicString = "Note";
    
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
        if (other.gameObject.CompareTag(musicString))
        {
            if (other.GetComponent<MusicNote>() != null)
            {
               
                    other.GetComponent<MusicNote>().SetMovingToHit(false);                
            }
            else if (other.GetComponent<EndHold>() != null)
            {
                other.GetComponent<EndHold>().GetAttachedGO().SetEndMovingToHit(false);
            }
        }
    }
}
