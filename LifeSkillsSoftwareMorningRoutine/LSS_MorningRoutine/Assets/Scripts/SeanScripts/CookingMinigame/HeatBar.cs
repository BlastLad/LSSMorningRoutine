using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatBar : MonoBehaviour
{
    [SerializeField]
    Slider attachedSlider;
    [SerializeField]
    float minVal = 0;
    float maxVal = 100;

    [SerializeField]
    float minSweetSpot;
    [SerializeField]
    float maxSweetSpot;


    public float hits = 0;
    int hitGain = 9;
    public float misses = 0;
    int missGain = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        attachedSlider.minValue = minVal;
        attachedSlider.maxValue = maxVal;
        attachedSlider.value = minVal;

        minSweetSpot = maxVal * 0.6f;
        maxSweetSpot = maxVal * 0.84f;

    }

    // Update is called once per frame
    void Update()
    {
      if (attachedSlider.value >= minSweetSpot && attachedSlider.value <= maxSweetSpot)
        {
            hits += hitGain * Time.deltaTime;
        } 
      else
        {
            misses += missGain * Time.deltaTime;
        }
    }

    public void ComparehitAndMiss()
    {
        if (hits >= misses)
        {
            Debug.Log("CONGRATS YOU WIN");
        }
        else
        {
            Debug.Log("WHOOPS YOU FAILED");

        }
    }


    public void ChangeValue(float val)
    {
        attachedSlider.value += val;
    }
}
