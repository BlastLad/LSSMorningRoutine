using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodObjectData : MonoBehaviour
{
    [SerializeField]
    string foodName;
    [SerializeField]
    Transform[] CutPoints;
    int currentCutPointNum = 0;
    //Thing for recipe attached?

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

    public Transform NextCut()
    {
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
