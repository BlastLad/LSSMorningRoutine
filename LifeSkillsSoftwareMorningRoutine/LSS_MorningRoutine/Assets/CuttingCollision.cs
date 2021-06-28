using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
            other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
            other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX;
            other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            //other.gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
