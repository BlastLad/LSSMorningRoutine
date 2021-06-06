using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPointController : MonoBehaviour
{

    string knifeString = "Knife";
    [SerializeField]
    GameObject foodObject;

    [SerializeField]
    GameObject sideArrow;
    [SerializeField]
    GameObject frontArrow;


    public void setFoodObject(GameObject val)
    {
        foodObject = val;
    }
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
        float zVal = other.GetComponent<KnifeSkills>().ChangePoint(foodObject).position.z;
        float xVal = foodObject.GetComponent<FoodObjectData>().GetCurrentCutPoint().position.x;
        transform.position = new Vector3(xVal, transform.position.y, zVal);
        
    }

    public void ChangeArrow(bool isFront)
    {
        if (isFront)
        {
            frontArrow.SetActive(true);
            sideArrow.SetActive(false);
        }
        else
        {
            frontArrow.SetActive(false);
            sideArrow.SetActive(true);
        }
    }
}
