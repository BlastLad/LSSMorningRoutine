using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPointController : MonoBehaviour
{

    string knifeString = "Knife";

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
        if (other.gameObject.CompareTag(knifeString))
        {
            nextPoint(other.gameObject);
        }
    }


    void nextPoint(GameObject other)
    {
        //comparer logic to see if on ground?

        transform.position = new Vector3(transform.position.x, transform.position.y, other.GetComponent<KnifeSkills>().ChangePoint().position.z);
        
    }
}
