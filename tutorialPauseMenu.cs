using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class tutorialPauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject cursorUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Timer.timerIsRunning)
        {
            if (GameManager.gameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        cursorUI.SetActive(true);
        GameManager.gameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        cursorUI.SetActive(false);
        GameManager.gameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading menu...");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
