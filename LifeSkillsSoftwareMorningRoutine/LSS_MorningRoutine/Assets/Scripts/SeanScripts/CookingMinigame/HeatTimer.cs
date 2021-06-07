using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatTimer : MonoBehaviour
{

    [SerializeField]
    Text countDowntext;
    [SerializeField]
    float baseTime = 30;
    bool isCounting = false;
    [SerializeField]
    HeatGameManager manager;

    // Start is called before the first frame update
    void Start()
    {

        countDowntext.text = "" + baseTime;

        BeginCountDown();
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            baseTime -= 1 * Time.deltaTime;

            countDowntext.text = "" + (int)baseTime;

            if (baseTime <= 0)
            {

                isCounting = false;
                EndMicroGame();
            }
        }
    }

    void EndMicroGame()
    {
        manager.getHeatBar().ComparehitAndMiss();
    }
    void BeginCountDown()
    {
        isCounting = true;
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        //end it
    }
}
