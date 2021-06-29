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

    public Sound Siz; 
    // Start is called before the first frame update
    void Start()
    {

        countDowntext.text = "" + baseTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting) //the count down for the timer logic
        {

            if (Siz != null)
            {
                if (Siz.source.isPlaying == false)
                {
                    AudioManager.instance.Play("Sizzle");
                }
            }
           
            baseTime -= 1 * Time.deltaTime;

            if (baseTime < 10)
            {
                countDowntext.text = "0" + (int)baseTime;
            }
            else
            {
                countDowntext.text = "" + (int)baseTime;
            }

            if (baseTime <= 0)
            {

                isCounting = false;
                EndMicroGame();
                AudioManager.instance.StopSound("Sizzle");
            }
        }
    }

    void EndMicroGame()//What ends the micro game
    {
        manager.getHeatBar().ComparehitAndMiss();
    }
    public void BeginCountDown()
    {
        manager.getHeatBar().ResetBar();
        Siz = AudioManager.instance.GetSound("Sizzle");       //What starts the timer's count down
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
