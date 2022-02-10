using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level0");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); //name of scene to load
    }
    public void LoadHelp()
    {
        SceneManager.LoadScene("HelpMenu");
    }
}
