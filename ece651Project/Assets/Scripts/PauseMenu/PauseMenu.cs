using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;


    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;          //freeze game
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;          //unfreeze game
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }


}
