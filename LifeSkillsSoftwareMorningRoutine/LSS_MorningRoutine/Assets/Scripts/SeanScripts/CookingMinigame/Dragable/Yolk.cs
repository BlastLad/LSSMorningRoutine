using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yolk : MonoBehaviour
{
    string bowlString = "BowlBottom";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(bowlString)) 
        {
            EggMicroGameController.instance.AddEgg();
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
