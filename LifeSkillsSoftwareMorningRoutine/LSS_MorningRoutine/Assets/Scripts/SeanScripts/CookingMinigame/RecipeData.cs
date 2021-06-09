using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeData : MonoBehaviour
{
    public string recipeName;
    [SerializeField]
    GameObject[] AttachedMicroGameObjects;
    public int currentIndex = -1; 

    //other variables for things like models to use for certain minigames and that junk


    public void LoadNextMicrogame()
    {
        if (currentIndex >= 0)
        {
            AttachedMicroGameObjects[currentIndex].GetComponent<MicroGameInterface>().DeactivateGame();
            AttachedMicroGameObjects[currentIndex].SetActive(false);
        }
        currentIndex++;

        if (currentIndex < AttachedMicroGameObjects.Length)
        {
            AttachedMicroGameObjects[currentIndex].SetActive(true);
            AttachedMicroGameObjects[currentIndex].GetComponent<MicroGameInterface>().ActivateGame();
        }
        else
        {
            Debug.Log("MINI GAME COMPLETE");//then call the manager
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
