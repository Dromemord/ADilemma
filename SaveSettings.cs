using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveSettings : MonoBehaviour
{
	public InputField MushroomInput;
	public InputField TimeInput;
	public Toggle RToggle;
	
	public void Back(){
		PlayerPrefs.SetInt("Number Mushroom", int.Parse(MushroomInput.text));
		PlayerPrefs.SetInt("Time Limit", int.Parse(TimeInput.text));
		if(RToggle.isOn){
			PlayerPrefs.SetInt("Right Click", 1);
			Debug.Log("Its on motherfucker");
		}else{
			PlayerPrefs.SetInt("Right Click", 0);
		}
		PlayerPrefs.Save();

	}
}
