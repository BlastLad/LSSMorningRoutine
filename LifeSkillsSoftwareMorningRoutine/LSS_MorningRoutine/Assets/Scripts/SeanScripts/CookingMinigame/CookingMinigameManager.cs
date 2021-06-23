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

        GetNextMicrogame();//for now will be after the recipe is picked in the future
    }

    public RecipeData GetCurrentRecipe()
    {
        return currentRecipe;
    }
    public void GetNextMicrogame()//what loads the net game based on recipe or ends the game if no more microgames
    {
        currentCam.Priority = 5;
        currentRecipe.LoadNextMicrogame();
        
    }


    public void SetCurrentCam(CinemachineVirtualCamera newCam)//setting thr current camera
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
        if (AudioManager.instance.GetTimesPlayed("Music") == 0 ) AudioManager.instance.PlaySoundIntervalToEnd(0f, "Music");
        if (AudioManager.instance.GetTimesPlayed("Music") > 0 && !AudioManager.instance.isPlaying("Music"))
            AudioManager.instance.PlaySoundIntervalToEnd(5.968333f, "Music");
    }

 
}
