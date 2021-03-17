using UnityEngine;
using UnityEngine.UI;

public class TutorialTimer : MonoBehaviour
{
    private float timeRemaining = 15;
    public Text timeText;

    void Update(){
        if (timeRemaining > 0){
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }else{
            timeRemaining = 0;
        }
    }

    void DisplayTime(float timeToDisplay){
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public float Query()
    {
        return timeRemaining;
    }
}
