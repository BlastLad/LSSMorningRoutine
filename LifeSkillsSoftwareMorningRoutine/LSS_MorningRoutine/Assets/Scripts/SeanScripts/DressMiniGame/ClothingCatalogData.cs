using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingCatalogData : MonoBehaviour
{
    [SerializeField]
    string sectionName;
    [SerializeField]
    GameObject PlayerObject;

    [SerializeField]
    GameObject[] itemsInCatalog;//FOR NOW WILL CHANGE ONCE THE MODELS ARE IN
    [SerializeField]
    GameObject[] clothingItemsInCatalog;

    [SerializeField]
    int clothingSection = 0;//0 head, 1 body, 2 leg

    [SerializeField]
    int currentIndex = 0;
    [SerializeField]
    int currentOutfitNum = 0;//0 beach, 1 work, 2 casual, 3 school

    bool isMoving = false;

    Quaternion toAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetCurrentOutfitNum()
    {
        return currentOutfitNum;
    }

    public int GetCurrentSecionNum()
    {
        return clothingSection;
    }

    public void GoLeft()
    {

        if (isMoving == false)
        {

            if (clothingItemsInCatalog[currentIndex].GetComponentInChildren<MeshRenderer>() != null)
            {
                clothingItemsInCatalog[currentIndex].GetComponentInChildren<MeshRenderer>().enabled = true;
            }

            itemsInCatalog[currentIndex].SetActive(false);

            if (currentIndex > 0)
            {
                currentIndex--;
            }
            else if (currentIndex == 0)
            {
                currentIndex = itemsInCatalog.Length - 1;
            }
            currentOutfitNum = clothingItemsInCatalog[currentIndex].GetComponent<ClothingItem>().outfitNumber;
            //A way to ensure that the active outfit model appears on the player model correctly (example disable to 'carasol model' enable the current outfit on player
            isMoving = true;
            AudioManager.instance.Play("Hanger");
            StartCoroutine(RotateMe(Vector3.up * -90, 0.8f));

        }
    }

    public void GoRight()
    {

        if (isMoving == false)
        {


            if (clothingItemsInCatalog[currentIndex].GetComponentInChildren<MeshRenderer>() != null)
            {
                clothingItemsInCatalog[currentIndex].GetComponentInChildren<MeshRenderer>().enabled = true;
            }
            itemsInCatalog[currentIndex].SetActive(false);


            if (currentIndex < itemsInCatalog.Length - 1)
            {
                currentIndex++;
            }
            else if (currentIndex == itemsInCatalog.Length - 1)
            {
                currentIndex = 0;
            }
            currentOutfitNum = clothingItemsInCatalog[currentIndex].GetComponent<ClothingItem>().outfitNumber;
            //A way to ensure that the active outfit model appears on the player model correctly (example disable to 'carasol model' enable the current outfit on player
            isMoving = true;
            AudioManager.instance.PlaySoundIntervalToEnd(0, "Hanger");

            StartCoroutine(RotateMe(Vector3.up * 90, 0.8f));

        }
    }


    IEnumerator RotateMe(Vector3 byAngles, float inTime)
    {
        var fromAngle = transform.rotation;
        toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
        //StartCoroutine(nextMovement(inTime + 2f));
        for (var t = 0f; t <= 1; t += Time.deltaTime / inTime)
        {
            transform.rotation = Quaternion.Slerp(fromAngle, toAngle, t);
            yield return null;

            
        }
        transform.rotation = toAngle;

        itemsInCatalog[currentIndex].SetActive(true);
        if (clothingItemsInCatalog[currentIndex].GetComponentInChildren<MeshRenderer>() != null)
        {

            clothingItemsInCatalog[currentIndex].GetComponentInChildren<MeshRenderer>().enabled = false;
        }



        isMoving = false;
        if (currentOutfitNum == 0)
            AudioManager.instance.PlaySoundIntervalToEnd(0f, "Beach");
        if (currentOutfitNum == 1)
            AudioManager.instance.PlaySoundIntervalToEnd(0f, "Work");
        if (currentOutfitNum == 2)
            AudioManager.instance.PlaySoundIntervalToEnd(0f, "Casual");
        if (currentOutfitNum == 3)
            AudioManager.instance.PlaySoundIntervalToEnd(0f, "School");

    }

    public void EndEarly()
    {
        if (isMoving)
        {

            transform.rotation = toAngle;


            itemsInCatalog[currentIndex].SetActive(true);
            if (clothingItemsInCatalog[currentIndex].GetComponentInChildren<MeshRenderer>() != null)
            {

                clothingItemsInCatalog[currentIndex].GetComponentInChildren<MeshRenderer>().enabled = false;
            }

            isMoving = false;
            
        }
    }


}
