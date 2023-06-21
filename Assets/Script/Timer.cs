using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 20;
    public Text timerText; //Décompte du temps
    private bool timerRunning = true;
    public GameObject prisonChasseur; //lieu clos ou le chasseur débute la partie
    public GameObject panel; //écran noir du chasseur au début de la partie
    public SimpleSampleCharacterControl cacheController; //afin que le caché ne puisse plus se déplacer à la fin de son temps pour se cacher
    public Text textTitleTime; //"Temps restant pour se cacher" / "Temps restant pour chasser"

    public GameOverScreen GameOverScreen;



    //Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            if (timerRunning == false)
            {
                GameOverScreen.Setup(timeToDisplay);
                timeToDisplay = 0;
            }
            else {
                textTitleTime.text = "Temps restant pour chasser";
                Destroy(panel);
                cacheController.SetControllerCacheEnabled(false);
                Destroy(prisonChasseur);
                timeValue = 120;
                timerRunning = false;
            }
        }
        else {
        
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = timeToDisplay % 1 * 1000;

        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
        }
    }

    public void ChasseurWin()
    {
        GameOverScreen.Setup(timeValue);
    }


}