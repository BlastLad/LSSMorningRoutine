using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CookingMinigameManager : MonoBehaviour
{
    public static CookingMinigameManager instance { get; private set; }

    [SerializeField]
    CinemachineVirtualCamera currentCam;
    [SerializeField]
    RecipeData currentRecipe;
 



    private void Awake()
    {
       
            instance = this;
        Debug.Log("HI" + gameObject.name);

        GetNextMicrogame();//for now will be after the recipe is picked in the future
    }

    public RecipeData GetCurrentRecipe()
    {
        return currentRecipe;
    }
    public void GetNextMicrogame()
    {
        currentCam.Priority = 5;
        currentRecipe.LoadNextMicrogame();
        
    }


    public void SetCurrentCam(CinemachineVirtualCamera newCam)
    {
        currentCam = newCam;
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
