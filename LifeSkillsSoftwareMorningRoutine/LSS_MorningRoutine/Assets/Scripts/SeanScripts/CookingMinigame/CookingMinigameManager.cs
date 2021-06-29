using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CookingMinigameManager : MonoBehaviour
{
    public static CookingMinigameManager instance { get; private set; }

    [SerializeField]
    CinemachineVirtualCamera currentCam;
    [SerializeField]
    RecipeData currentRecipe;

    [SerializeField]
    GameObject recipeSelection;
    [SerializeField]
    GameObject selectionText;


    [SerializeField]
    GameObject reportNoteBook;

    [SerializeField]
    Text[] gameText;
    [SerializeField]
    Text[] reportText;
    [SerializeField]
    public Text[] fillableField;

    public int index = -1;
    private void Awake()
    {
            instance = this;

        recipeSelection.SetActive(true);
        selectionText.SetActive(true);

       
    }


    public void ChooseRecipe(RecipeData recipe)
    {
        currentRecipe = recipe;
        recipeSelection.SetActive(false);
        selectionText.SetActive(false);
        GetNextMicrogame();
    }

    public RecipeData GetCurrentRecipe()
    {
        return currentRecipe;
    }
    public void GetNextMicrogame()//what loads the net game based on recipe or ends the game if no more microgames
    {
        currentCam.Priority = 5;
        index++;
        currentRecipe.LoadNextMicrogame();
        if(index > 0) AudioManager.instance.Play("Yay");
        
    }


    public void SetCurrentCam(CinemachineVirtualCamera newCam)//setting thr current camera
    {
        currentCam.Priority = 5;
        currentCam = newCam;
        currentCam.Priority = 11;
    }


    public void Report()
    {
        reportNoteBook.SetActive(true);
        for (int i = 0; i < gameText.Length; i++)
        {
            gameText[i].text = currentRecipe.gamesName[i];
            reportText[i].text = currentRecipe.reportText[i];
        }
    }

    public void ReturnToMain()
    {
        PlayerStats.madeBreakfast = true;
        SceneManager.LoadScene(0);
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
