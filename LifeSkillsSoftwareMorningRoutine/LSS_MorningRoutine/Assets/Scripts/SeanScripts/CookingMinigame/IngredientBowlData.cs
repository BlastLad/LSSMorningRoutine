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
        }
        else if (ingredientID == 2)
        {
            name.text = "BlueBerries";
        }
        else if (ingredientID == 3)
        {
            name.text = "Oranges";
        }
        else if (ingredientID == 4)
        {
            name.text = "Toast";
        }
        else if (ingredientID == 5)
        {
           name.text = "Potatoes";
        }

        tempRenderer.material = tempMat;

        completeCheckBox = checkBox;
   

    }

    public void crossOut()
    {
        if (completeCheckBox != null)
        {
            completeCheckBox.SetActive(true);
            //crossoutSFX
        }

    }

    public void ResetPosition()
    {
        transform.position = startingPos;
    }

}
