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
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level 5");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
