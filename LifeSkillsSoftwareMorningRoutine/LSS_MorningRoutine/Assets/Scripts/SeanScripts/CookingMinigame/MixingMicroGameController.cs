using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using UnityEngine.UI;
public class MixingMicroGameController : MonoBehaviour, MicroGameInterface
{
    public static MixingMicroGameController instance { get; private set; }

    [SerializeField]
    GameObject[] requiredGameObjects;

    [SerializeField]
    GameObject[] checkBoxes;

    [SerializeField]
    Material[] tempMaterials;

    public Text RecipeName;

    [SerializeField]
    GameObject stirrer;

    [SerializeField]// will probs change this to a scriptable object at somepoint in the future
    int targetedRecipe;// 0 for Pancake, 1 for Breakfest Burrito, 2 for Toast

    [SerializeField]
    List<int> requiredIngredients = new List<int>();

    [SerializeField]
    List<Text> recipeFields = new List<Text>();
    
    [SerializeField]
    List<Text> ingredientCheckBoxName = new List<Text>();


    public int allowedIngredients = 0;
    int ingredientsAdded = 0;


    bool addedCorrectly = true;
    bool mixedCorrectly = true;


    [SerializeField]
    IngredientBowlData[] ingredientBowls;
    int correctIngredients = 0;
    bool shouldMix = false;

    [SerializeField]
    IngredientBowlData currentIngredient;


    public GameObject placeText;
    public GameObject mixText;

    public CinemachineVirtualCamera placeCam;//front camera
    public CinemachineVirtualCamera stirCam;//front camera

    [SerializeField]
    GameObject mixTutorial;

    [SerializeField]
    GameObject[] interiorBlueBerries;
    int Blueberryindex = 0;
    [SerializeField]
    GameObject interiorPancakemix;
    [SerializeField]
    GameObject[] interiorEggs;
    int eggsIndex = 0;
    [SerializeField]
    GameObject[] interiorOranges;
    int orangeIndex = 0;
    [SerializeField]
    GameObject[] interiorToast;
    int toastindex = 0;
    [SerializeField]
    GameObject[] InteriorPotato;
    int potatoIndex = 0;

    private void Awake()
    {
        if (instance == null)
        {
            targetedRecipe = CookingMinigameManager.instance.GetCurrentRecipe().recipeNum;
            instance = this;

            if (targetedRecipe == 0)
            {
                RecipeName.text = "Blueberry Pancakes";

                requiredIngredients.Add(0);//pancakemix
                requiredIngredients.Add(0);//pancakemix
                requiredIngredients.Add(1);//eggs
                requiredIngredients.Add(1);//eggs
                requiredIngredients.Add(1);//eggs
                requiredIngredients.Add(2);//blue berries
                requiredIngredients.Add(2);//blue berries

                recipeFields[recipeFields.Count - 1].transform.parent.gameObject.SetActive(false);
                recipeFields.RemoveAt(recipeFields.Count - 1);
                recipeFields[recipeFields.Count - 1].transform.parent.gameObject.SetActive(false);
                recipeFields.RemoveAt(recipeFields.Count - 1);

                recipeFields[0].text = "2";
                recipeFields[1].text = "3";
                recipeFields[2].text = "2";

                shouldMix = true;
            }
            else if (targetedRecipe == 1)//burrito
            {
                RecipeName.text = "Breakfast Burrito";


                requiredIngredients.Add(1);//egg
                requiredIngredients.Add(1);//egg
                requiredIngredients.Add(5);//potato
                requiredIngredients.Add(5);//potato


                recipeFields[recipeFields.Count - 1].transform.parent.gameObject.SetActive(false);
                recipeFields.RemoveAt(recipeFields.Count - 1);
                recipeFields[recipeFields.Count - 1].transform.parent.gameObject.SetActive(false);
                recipeFields.RemoveAt(recipeFields.Count - 1);
                recipeFields[recipeFields.Count - 1].transform.parent.gameObject.SetActive(false);
                recipeFields.RemoveAt(recipeFields.Count - 1);

                recipeFields[0].text = "2";
                recipeFields[1].text = "2";
                shouldMix = true;
            }
            else if (targetedRecipe == 2)//toast
            {
                RecipeName.text = "Egg On Toast";

                requiredIngredients.Add(1);//egg
                requiredIngredients.Add(1);//egg
                requiredIngredients.Add(4);//toast
                requiredIngredients.Add(3);//orange
                
                recipeFields[recipeFields.Count - 1].transform.parent.gameObject.SetActive(false);
                recipeFields.RemoveAt(recipeFields.Count - 1);
                recipeFields[recipeFields.Count - 1].transform.parent.gameObject.SetActive(false);
                recipeFields.RemoveAt(recipeFields.Count - 1);

                recipeFields[0].text = "2";//egg
                recipeFields[1].text = "1";//orange
                recipeFields[2].text = "1";//toast


                shouldMix = false;
            }

            allowedIngredients = requiredIngredients.Count;

            SetUpBowls();

        }
        else
        {
            Debug.LogWarning("UH OH MIXING GAME CONTROLLER OCCUIPIED");
        }
    }

    public void SetUpBowls()
    {
        if (targetedRecipe == 0)
        {                            
            ingredientBowls[0].SetIngredientID(0, ingredientCheckBoxName[0], checkBoxes[0], tempMaterials[0]);//Pancake mix
            ingredientBowls[1].SetIngredientID(1, ingredientCheckBoxName[1], checkBoxes[1], tempMaterials[1]);//Egg
            ingredientBowls[2].SetIngredientID(2, ingredientCheckBoxName[2], checkBoxes[2], tempMaterials[2]);//Blueberry
            ingredientBowls[3].SetIngredientID(3, ingredientCheckBoxName[3], checkBoxes[3], tempMaterials[3]);//orange
            ingredientBowls[4].SetIngredientID(4, ingredientCheckBoxName[4], checkBoxes[4], tempMaterials[4]);//toast            
        }
        else if (targetedRecipe == 1)
        {
            ingredientBowls[2].SetIngredientID(0, ingredientCheckBoxName[4], checkBoxes[4], tempMaterials[0]);//PancakeMix
            ingredientBowls[4].SetIngredientID(3, ingredientCheckBoxName[2], checkBoxes[2], tempMaterials[3]);//Orange
            ingredientBowls[0].SetIngredientID(1, ingredientCheckBoxName[0], checkBoxes[0], tempMaterials[1]);//Egg
            ingredientBowls[3].SetIngredientID(4, ingredientCheckBoxName[3], checkBoxes[3], tempMaterials[4]);//Toast
            ingredientBowls[1].SetIngredientID(5, ingredientCheckBoxName[1], checkBoxes[1], tempMaterials[5]);//Potato 
        }
        else if (targetedRecipe == 2)
        {
            ingredientBowls[0].SetIngredientID(5, ingredientCheckBoxName[4], checkBoxes[4], tempMaterials[5]);//Potato
            ingredientBowls[1].SetIngredientID(3, ingredientCheckBoxName[1], checkBoxes[1], tempMaterials[3]);//Orange
            ingredientBowls[2].SetIngredientID(2, ingredientCheckBoxName[3], checkBoxes[3], tempMaterials[2]);//BlueBerry
            ingredientBowls[3].SetIngredientID(4, ingredientCheckBoxName[2], checkBoxes[2], tempMaterials[4]);//Toast
            ingredientBowls[4].SetIngredientID(1, ingredientCheckBoxName[0], checkBoxes[0], tempMaterials[1]);//Egg

        }
    }

    public IngredientBowlData GetCurrentIngredientData()
    {
        return currentIngredient;
    }
    public void SetTargetedRecipe(int num)
    {
        targetedRecipe = num;
    }

    public int GetTargetedRecipe()
    {
        return targetedRecipe;
    }


    public void AddToMixingBowl()
    {
        int ingredientMarkedForDeletion = -1;

        Debug.Log("SUCCESSFULLY CALLED ADD TO MIXING BOWL");

        foreach (int recipeComponent in requiredIngredients)
        {
            if (recipeComponent == currentIngredient.GetIngredientID())
            {
                ingredientMarkedForDeletion = currentIngredient.GetIngredientID();                
                correctIngredients++;
            }

            
        }
        ingredientsAdded++;

        if (ingredientMarkedForDeletion != -1)
        {
            requiredIngredients.Remove(ingredientMarkedForDeletion);
            AddInterior(ingredientMarkedForDeletion);
            if (!requiredIngredients.Contains(currentIngredient.GetIngredientID()))
            {
                Debug.Log("WHATEVES" + currentIngredient.GetIngredientID() + requiredIngredients.Contains(currentIngredient.GetIngredientID()));

                currentIngredient.crossOut();
            }
            //goodparticle effect
            //good soundclip
        }
        else
        {
            //bad particle effect
            //bad soundclip
        }


        if (ingredientsAdded > allowedIngredients || requiredIngredients.Count == 0)
        {
            CheckForMix();
        }
    }

    public void AddInterior(int ingredientIDNum)
    {

        if (ingredientIDNum == 0)
        {
            interiorPancakemix.SetActive(true);
        }
        else if (ingredientIDNum == 1)
        {
            interiorEggs[eggsIndex].SetActive(true);
            eggsIndex++;
        }
        else if (ingredientIDNum == 2)
        {
            interiorBlueBerries[Blueberryindex].SetActive(true);
            Blueberryindex++;
        }
        else if (ingredientIDNum == 3)
        {
            interiorOranges[orangeIndex].SetActive(true);
            orangeIndex++;
        }
        else if (ingredientIDNum == 4)
        {
            interiorToast[toastindex].SetActive(true);
            toastindex++;
        }
        else if (ingredientIDNum == 5)
        {
            InteriorPotato[potatoIndex].SetActive(true);
            potatoIndex++;
        }
    }


    public void CheckForMix()
    {
        if (ingredientsAdded != allowedIngredients)//if you went over the number of allowed ingredients than you messed up once
        {
            addedCorrectly = false;
        }

        Debug.Log("The ingredients were added " + addedCorrectly);

        if (shouldMix)
        {
            BeginMix();
        }
        else
        {
            CookingMinigameManager.instance.fillableField[CookingMinigameManager.instance.index].text = "" + (ingredientsAdded - correctIngredients);
            CookingMinigameManager.instance.GetNextMicrogame();//need victory screen
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<IngredientBowlData>() != null)
        {
            currentIngredient = other.gameObject.GetComponent<IngredientBowlData>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<IngredientBowlData>() != null)
        {
            currentIngredient = null;
        }
    }

    public void BeginMix()
    {
        ChangeCamera();

        placeText.SetActive(false);
        mixText.SetActive(true);

        stirrer.SetActive(true);
    }

    public void ActivateGame()
    {
        mixTutorial.SetActive(true);

        CookingMinigameManager.instance.SetCurrentCam(placeCam);
        foreach (GameObject preReq in requiredGameObjects)
        {
            preReq.SetActive(true);
        }
    }

    public void DeactivateGame()
    {
        foreach (GameObject preReq in requiredGameObjects)
        {
            preReq.SetActive(false);
        }
        mixText.SetActive(false);
    }


    public void ChangeCamera()//changes camera between the side and front view
    {
      
            placeCam.Priority = 9;
            stirCam.Priority = 10;
            CookingMinigameManager.instance.SetCurrentCam(stirCam);    

    }

    public int GetIngredientsAdded()
    {
        return ingredientsAdded;
    }

    public int GetCorrectIngredients()
    {
        return correctIngredients;
    }
}
