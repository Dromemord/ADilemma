using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PseudoMenu : MonoBehaviour
{
	public InputField PlayerName;
	const string glyphs= "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

	void Start(){
		PlayerName.placeholder.GetComponent<Text>().text = "";


		for(int i=0; i<6; i++)
		{
			PlayerName.placeholder.GetComponent<Text>().text += glyphs[Random.Range(0, glyphs.Length)];
		}
	}

	public void PlayGame(){
		if(PlayerName.placeholder.GetComponent<Text>().text != ""){
			PlayerPrefs.SetString("Player Name", PlayerName.placeholder.GetComponent<Text>().text);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

}
