using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField]
    GameObject playerGO;
    [SerializeField]
    Transform SpawnPos;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (playerGO.transform.position.y < -20)
        {
            playerGO.transform.position = SpawnPos.transform.position;
            playerGO.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
