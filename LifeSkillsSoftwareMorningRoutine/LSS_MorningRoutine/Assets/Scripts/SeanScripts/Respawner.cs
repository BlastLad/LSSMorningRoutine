using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField]
    GameObject playerGO;
    Vector3 initialPos;
    
    // Start is called before the first frame update
    void Start()
    {
        initialPos = playerGO.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (playerGO.transform.position.y < -20)
        {
            playerGO.transform.position = initialPos;
            playerGO.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
