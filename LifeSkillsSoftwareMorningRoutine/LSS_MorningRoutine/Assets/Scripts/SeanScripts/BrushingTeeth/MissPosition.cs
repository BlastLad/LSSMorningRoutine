using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissPosition : MonoBehaviour
{
    string musicString = "Note";
    [SerializeField]
    bool isLeft;
    [SerializeField]
    LeftPlayerControl leftControl;
    [SerializeField]
    RightPlayerControl rightControl;

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
            if (isLeft)
            {
                if (other.gameObject.GetComponent<EndHold>() != null)
                {
                    leftControl.destroyNote(false, other.gameObject);
                }
                else
                {
                    leftControl.destroyNote(false);
                }
            }
            else
            {
                if (other.gameObject.GetComponent<EndHold>() != null)
                {
                    rightControl.destroyNote(false, other.gameObject);
                }
                else
                {
                    rightControl.destroyNote(false);
                }
            }
        }
    }
}
