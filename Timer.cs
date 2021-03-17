using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeRemaining;
    public static bool timerIsRunning = false;
    public Text timeText;

    private void Start()
    {
    	if (PlayerPrefs.HasKey("Time Limit")) {
    		timeRemaining = PlayerPrefs.GetInt("Time Limit");
    	} else {
    		timeRemaining = 616;
    		PlayerPrefs.SetInt("Time Limit", 616);
            PlayerPrefs.Save();
    	}
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                if (!GameManager.gameIsPaused) {
                    timeRemaining -= Time.deltaTime;
                }
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                GameObject.FindWithTag("Canvas").GetComponent<EndMenu>().End();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
