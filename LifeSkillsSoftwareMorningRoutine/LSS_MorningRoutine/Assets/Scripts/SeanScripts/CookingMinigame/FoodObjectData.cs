using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodObjectData : MonoBehaviour
{
    [SerializeField]
    string foodName;
    [SerializeField]
    Transform[] CutPoints;//how many points the object has that needs to be cut
    int currentCutPointNum = 0;
    [SerializeField]
    Rigidbody[] pieces;
    //Thing for recipe attached?
    [SerializeField]
    public GameObject orangeObject;
    [SerializeField]
    public GameObject breadObject;
    public Transform[] GetCutPoints()
    {
        return CutPoints;
    }

    public Transform GetCurrentCutPoint()
    {
        if (currentCutPointNum < CutPoints.Length)
        {
            return CutPoints[currentCutPointNum];
        }
        else
        {
            return CutPoints[0];
        }
    }

    public Transform NextCut()//what moves from one cut point to the other and determies the approtiate camera
    {
        pieces[currentCutPointNum].AddForce(new Vector3(-15,0,0));
        pieces[currentCutPointNum].useGravity = true;
        pieces[currentCutPointNum].gameObject.GetComponent<Collider>().enabled = true;

        currentCutPointNum++;

        if (currentCutPointNum < CutPoints.Length)
        {
            int remainder = (currentCutPointNum % 2);
            if (remainder == 0)
            {
                CuttingMicroGameManager.instance.ChangeCamera(true);
            }
            else
            {
                CuttingMicroGameManager.instance.ChangeCamera(false);

            }


            return CutPoints[currentCutPointNum];
        }
        else
        {
            CuttingMicroGameManager.instance.ChangeCamera(true);
            return null;
        }

    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
