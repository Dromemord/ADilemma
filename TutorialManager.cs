using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popups;
    private int popupIndex = 0;
    public float waitTime = 3;

    public GameObject pauseMenuUI;

    public GameObject UI;

    public GameObject Mushroom;

    public Compteur cpt;

    public GameObject Timer;

    public TutorialTimer time;
    // Update is called once per frame

    void Start(){
        GameManager.gameIsPaused = false;
    }

    void Update()
    {
        for (int i = 0; i < popups.Length; i++) {
            if(i == popupIndex){
                popups[i].SetActive(true);
            }else{
                popups[i].SetActive(false);
            }
        }

        if(popupIndex == 0){
            if(waitTime <= 0){
                popupIndex++;
                waitTime = 0;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 1){
            if(Input.GetKeyDown(KeyCode.Z) && waitTime <= 0){
                popupIndex++;
                waitTime = 0;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 2){
            if(Input.GetKeyDown(KeyCode.S) && waitTime <= 0){
                popupIndex++;
                waitTime = 0;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 3){

            if(Input.GetKeyDown(KeyCode.Q) && waitTime <= 0){
                popupIndex++;
                waitTime = 0;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 4){
            if(Input.GetKeyDown(KeyCode.D) && waitTime <= 0){
                popupIndex++;
                waitTime = 0;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 5){
            if(Input.GetButton("Jump") && waitTime <= 0){
                popupIndex++;
                waitTime = 2;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 6){
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameManager.gameIsPaused)
                {
                    Resume();
                } else
                {
                    popupIndex++;
                    Pause();
                }
            }
        }else if(popupIndex == 8){
            UI.SetActive(true);
            if(waitTime <= 0){
                popupIndex++;
                waitTime = 2;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 9){
            if(waitTime <= 0){
                Mushroom.SetActive(true);
                popupIndex++;
                waitTime = 2;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 10){
            if(waitTime <= 0){
                popupIndex++;
                waitTime = 2;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 11){
            if(waitTime <= 0){
                popupIndex++;
                waitTime = 2;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 12){
            if(cpt.Query() != 0){
                popupIndex++;
                waitTime = 2;
            }
        }else if(popupIndex == 13){
            if(waitTime <= 0){
                popupIndex++;
                waitTime = 4;
                Timer.SetActive(true);
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 14){
            if(waitTime <= 0){
                popupIndex++;
                waitTime = 2;
            }else{
                waitTime -= Time.deltaTime;
            }
        }else if(popupIndex == 15){
            if(Input.GetKeyDown(KeyCode.Return) || time.Query() <= 0){
                popupIndex++;
            }
        }else if(popupIndex == 16){
            GameManager.gameIsPaused = true;
            Timer.SetActive(false);
            UI.SetActive(false);
        }
    }

    public void Resume()
    {
        popupIndex++;
        pauseMenuUI.SetActive(false);
        GameManager.gameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
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
