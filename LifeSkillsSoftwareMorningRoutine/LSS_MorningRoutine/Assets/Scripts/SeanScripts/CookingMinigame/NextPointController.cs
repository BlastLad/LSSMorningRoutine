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

    int cuts = 0;

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


    private void OnTriggerEnter(Collider other)//trigger collider for when the knife completes a cut
    {
        if (other.gameObject.CompareTag(knifeString))
        {
            nextPoint(other.gameObject);
            if (cuts > 5) cuts = 0;
            cuts++;
            AudioManager.instance.Play("Portion " + cuts);
        }
    }


    void nextPoint(GameObject other)// more logic for the changing of cuts
    {
        //comparer logic to see if on ground?
        float zVal = other.GetComponent<KnifeSkills>().ChangePoint(foodObject).position.z;
        float xVal = foodObject.GetComponent<FoodObjectData>().GetCurrentCutPoint().position.x;
        transform.position = new Vector3(xVal, transform.position.y, zVal);
        
    }

    public void ChangeArrow(bool isFront)//what chanegs the arrow from 1 to the next
    {
        int cuts = 0;

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
