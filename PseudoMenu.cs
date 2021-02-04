using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PseudoMenu : MonoBehaviour
{
	public InputField PlayerName;
	
	public void PlayGame(){
		if(PlayerName.text != ""){
			PlayerPrefs.SetString("Player Name", PlayerName.text);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
	
}
