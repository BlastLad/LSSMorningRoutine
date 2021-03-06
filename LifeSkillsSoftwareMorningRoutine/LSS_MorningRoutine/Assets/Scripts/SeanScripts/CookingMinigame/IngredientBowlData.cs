using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IngredientBowlData : MonoBehaviour
{
    [SerializeField]
    int ingredientID = 0; //0 pancake mix, 1 eggs, 2 blueberries, 3 orange, 4 toast, 5 for potato

    Vector3 startingPos;

    [SerializeField]
    public GameObject completeCheckBox;
    [SerializeField]
    public GameObject unfilledCheckBox;

    [SerializeField]
    public GameObject eggs;
    [SerializeField]
    public GameObject blueBerry;
    [SerializeField]
    public GameObject toast;
    [SerializeField]
    public GameObject Oranges;
    [SerializeField]
    public GameObject potato;

    public MeshRenderer tempRenderer;

    // Partcile Effect
    //Audio clip for crossingout
    // bowl interior


    private void Awake()
    {
        startingPos = transform.position;
    }
    public int GetIngredientID()
    {
        return ingredientID;
    }

    public void SetIngredientID(int num, Text name, GameObject checkBox, Material tempMat)
    {
        ingredientID = num;

        if (ingredientID == 0)
        {
            name.text = "Pancake Mix";
        }
        else if (ingredientID == 1)
        {
            name.text = "Eggs";
            eggs.SetActive(true);
        }
        else if (ingredientID == 2)
        {
            name.text = "BlueBerries";
            blueBerry.SetActive(true);
        }
        else if (ingredientID == 3)
        {
            name.text = "Oranges";
            Oranges.SetActive(true);
        }
        else if (ingredientID == 4)
        {
            name.text = "Toast";
            toast.SetActive(true);
        }
        else if (ingredientID == 5)
        {
           name.text = "Potatoes";
            potato.SetActive(true);
        }

        tempRenderer.material = tempMat;

        completeCheckBox = checkBox;
   

    }

    public void crossOut()
    {
        if (completeCheckBox != null)
        {
            completeCheckBox.SetActive(true);
            if (AudioManager.instance.GetSound("Scratch") != null) AudioManager.instance.Play("Scratch");
        }

    }

    public void ResetPosition()
    {
        transform.position = startingPos;
       
        if(AudioManager.instance.GetSound("Splish") != null) AudioManager.instance.Play("Splish");
    }
}
