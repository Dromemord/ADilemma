using UnityEngine;

public class EndMenu : MonoBehaviour
{
    public GameObject endMenuUI;
    public GameObject cursorUI;
    public GameObject timerUI;
    public GameObject counterUI;

    public EmailFactory email;


    public void RestartGame()
    {
        SaveSystem.SavePlayer();
        email.SendEmail();
        
        endMenuUI.SetActive(false);
        GameManager.gameIsPaused = false;
        GameManager.Restart();
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        SaveSystem.SavePlayer();
        email.SendEmail();
        Application.Quit();
    }

    public void End()
    {
        endMenuUI.SetActive(true);
        cursorUI.SetActive(false);
        timerUI.SetActive(false);
        counterUI.SetActive(false);
        GameManager.gameIsPaused = true;
    }
    
    public void DevQuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
