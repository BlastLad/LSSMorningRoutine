using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Egg : MonoBehaviour
{

    string CartonString = "Carton";

    [SerializeField]
    float eggBreakMagnitude = 5f;
    [SerializeField]
    float eggCrackMagnitude = .42f;

    bool isCracked = false;
    [SerializeField]
    GameObject yolk;
    [SerializeField]
    GameObject baseEgg;
    [SerializeField]
    GameObject crackedEgg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetIsCracked()
    {
        return isCracked;
    }

    public void ResetPosition()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y, startingPosition.z);
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(CartonString))
        {

        }
        else
        {
            if (GetComponent<Rigidbody>().velocity.magnitude >= eggBreakMagnitude)
            {
               EggMicroGameController.instance.SetSpeedText("Too Fast");
                SpawnNewEgg();
            }
            else if (GetComponent<Rigidbody>().velocity.magnitude < eggCrackMagnitude)
            {
                EggMicroGameController.instance.SetSpeedText("Too Slow");
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

            }
            else if (other.gameObject.CompareTag("Bowl"))
            {
                if (isCracked)
                {
                    EggMicroGameController.instance.SetSpeedText("");
                    SpawnNewEgg();
                }
                else
                {
                    EggMicroGameController.instance.SetSpeedText("");
                    isCracked = true;
                    baseEgg.SetActive(false);
                    crackedEgg.SetActive(true);
                    EggMicroGameController.instance.EnableCrackImage();
                }
            }
        }
    }

    public void SpawnNewEgg()
    {
        EggMicroGameController.instance.SpawnNewEgg();
        Destroy(gameObject);

    }

    public void SpawnYolk()
    {
        Instantiate(yolk, transform.position, Quaternion.identity);
        SpawnNewEgg();
    }

}
