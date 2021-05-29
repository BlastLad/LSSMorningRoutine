using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingCatalogData : MonoBehaviour
{
    [SerializeField]
    string sectionName;
    [SerializeField]
    GameObject ProBuilderBlock;

    [SerializeField]
    Material[] itemsInCatalog;//FOR NOW WILL CHANGE ONCE THE MODELS ARE IN
    [SerializeField]
    GameObject[] clothingItemsInCatalog;


    [SerializeField]
    int currentIndex = 0;
    [SerializeField]
    int currentOutfitNum = 0;//0 beach, 1 work, 2 casual, 3 school

    bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoLeft()
    {
        if (currentIndex > 0)
        {
            if (isMoving == true)
            {
                return;
            }
            AudioManager.instance.Play("Hanger");
            currentIndex--;
            ProBuilderBlock.GetComponent<MeshRenderer>().material = itemsInCatalog[currentIndex];
            currentOutfitNum = clothingItemsInCatalog[currentIndex].GetComponent<ClothingItem>().outfitNumber;
            //A way to ensure that the active outfit model appears on the player model correctly (example disable to 'carasol model' enable the current outfit on player
            isMoving = true;
            StartCoroutine(RotateMe(Vector3.up * -90, 0.8f));
        }
    }

    public void GoRight()
    {
        if (currentIndex < itemsInCatalog.Length - 1)
        {
            if (isMoving == true)
            {
                return;
            }
            AudioManager.instance.PlaySoundIntervalToEnd(0f, "Hanger");
            currentIndex++;
            ProBuilderBlock.GetComponent<MeshRenderer>().material = itemsInCatalog[currentIndex];
            currentOutfitNum = clothingItemsInCatalog[currentIndex].GetComponent<ClothingItem>().outfitNumber;
            //A way to ensure that the active outfit model appears on the player model correctly (example disable to 'carasol model' enable the current outfit on player
            isMoving = true;
            StartCoroutine(RotateMe(Vector3.up * 90, 0.8f));



        }
    }


    IEnumerator RotateMe(Vector3 byAngles, float inTime)
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
        isMoving = false;
        if (currentIndex == 0)
            AudioManager.instance.PlaySoundIntervalToEnd(0f, "Beach");
        if (currentIndex == 1)
            AudioManager.instance.PlaySoundIntervalToEnd(0f, "Work");
        if (currentIndex == 2)
            AudioManager.instance.PlaySoundIntervalToEnd(0f, "Casual");
        if (currentIndex == 3)
            AudioManager.instance.PlaySoundIntervalToEnd(0f, "School");

    }


}
