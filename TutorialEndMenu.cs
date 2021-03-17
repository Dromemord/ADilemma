using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialEndMenu : MonoBehaviour
{
    public GameObject endMenuUI;
    public GameObject timerUI;
    public GameObject counterUI;

    public void RestartGame()
    {
        endMenuUI.SetActive(false);
        GameManager.gameIsPaused = false;
        GameManager.Restart();
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void Jouer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
