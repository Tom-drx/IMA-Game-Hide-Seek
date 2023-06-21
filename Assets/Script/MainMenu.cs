using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Principal");
    }
    public void RulesGame()
    {
        SceneManager.LoadScene("Règles");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
