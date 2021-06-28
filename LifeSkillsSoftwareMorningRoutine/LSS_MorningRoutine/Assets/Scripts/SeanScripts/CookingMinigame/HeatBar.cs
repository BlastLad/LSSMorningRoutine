using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatBar : MonoBehaviour
{
    [SerializeField]
    Slider attachedSlider;//The attached sldier graphic
    [SerializeField]
    float minVal = 0;
    float maxVal = 100;

    [SerializeField]
    float minSweetSpot;// start of the sweet spot
    [SerializeField]
    float maxSweetSpot;// end of the sweet spot


    public float hits = 0;//How many successful 'points' the player has
    int hitGain = 9; //The rate at which the player gains successful 'points'
    public float misses = 0;//How many unsuccessful 'points' the player has
    int missGain = 5;//The rate at which the player gains unsuccessful 'points'

    // Start is called before the first frame update
    void Start()
    {
        attachedSlider.minValue = minVal;
        attachedSlider.maxValue = maxVal;
        attachedSlider.value = minVal;

        minSweetSpot = maxVal * 0.6f;
        maxSweetSpot = maxVal * 0.86f;

    }

    // Update is called once per frame
    void Update()
    {
      if (attachedSlider.value >= minSweetSpot && attachedSlider.value <= maxSweetSpot)//if the player is in the sweetspot
        {
            hits += hitGain * Time.deltaTime;
        } 
      else// if the player is not in the sweet spot
        {
            misses += missGain * Time.deltaTime;
          //  if (attachedSlider.value < minSweetSpot) AudioManager.instance.LowerPitch("Music", .5f);
            //if (attachedSlider.value > maxSweetSpot) AudioManager.instance.RaisePitch("Music", .5f);
        }
    }

    public void ComparehitAndMiss()//The end of the micro game
    {
        float percent = (hits / (hits + misses)) * 100;
        CookingMinigameManager.instance.fillableField[CookingMinigameManager.instance.index].text = "" + percent.ToString("F2") + "%";
        if (hits >= misses)//if the player was successful in the game
        {
            CookingMinigameManager.instance.GetNextMicrogame();//probs gonna need to pass in data to the recipe or game manager
        }
        else//if the player was not successful
        {
            CookingMinigameManager.instance.GetNextMicrogame();//same as above
            Debug.Log("WHOOPS YOU FAILED");

        }
    }


    public void ChangeValue(float val)
    {
        attachedSlider.value += val;
    }
}
