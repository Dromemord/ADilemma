using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameIsPaused = false;

    void Start()
    {
        Debug.Log("I'am here !");
        if (!PlayerPrefs.HasKey("Time Limit"))
            PlayerPrefs.SetInt("Time Limit" , 150);
        if (!PlayerPrefs.HasKey("Number Mushroom"))
            PlayerPrefs.SetInt("Number Mushroom", 100);
        if (!PlayerPrefs.HasKey("Player Name"))
            PlayerPrefs.SetString("Player Name", "DON'T SAVE THIS");
        PlayerPrefs.Save();
    }

    public static void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
