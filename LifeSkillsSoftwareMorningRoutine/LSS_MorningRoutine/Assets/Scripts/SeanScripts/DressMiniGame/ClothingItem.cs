using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingItem : MonoBehaviour
{
    [SerializeField]
    int clothingSection = 0;//0 head, 1 body, 2 leg
    [SerializeField]
    public int outfitNumber = 0;//0 beach, 1 work, 2 casual, 3 school
    Quaternion initalRotaion;
    
    // Start is called before the first frame update
    void Start()
    {
        initalRotaion = transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (gameObject.activeInHierarchy)
        {
            transform.rotation = initalRotaion;
            
        }
    }


    public IEnumerator RotateMe(Vector3 byAngles, float inTime)
    {
        var fromAngle = transform.rotation;
        var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
        //StartCoroutine(nextMovement(inTime + 2f));
        for (var t = 0f; t <= 1; t += Time.deltaTime / inTime)
        {
            transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;


        }
        transform.rotation = toAngle;
        

    }

}
