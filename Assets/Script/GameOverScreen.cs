using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text gameOver;
    public Text time;


    public void Setup(float timeDisplay)
    {
            gameObject.SetActive(true);
            if (timeDisplay > 0)
            {
                time.text = timeDisplay.ToString() + " secondes restantes, " + (120-timeDisplay).ToString() +" secondes �coul�es";
                gameOver.text = "Bravo !";
            }
            else {
                time.text = "Les 2 minutes sont �coul�es";
                gameOver.text = "Game Over !";
            }
        
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Principal");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
