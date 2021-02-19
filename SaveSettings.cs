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

	public Scrollbar scr1;
	public Scrollbar scr2;
	public Scrollbar scr3;
	public Scrollbar scr4;
	public Scrollbar scr5;
	public Scrollbar scr6;
	public Scrollbar scr7;
	public Scrollbar scr8;
	public Scrollbar scr9;
	public Scrollbar scr10;
	public Scrollbar scr11;
	public Scrollbar scr12;
	public Scrollbar scr13;
	public Scrollbar scr14;
	public Scrollbar scr15;
	public Scrollbar scr16;
	public Scrollbar scr17;
	public Scrollbar scr18;

	public void Back(){
		PlayerPrefs.SetInt("Number Mushroom", int.Parse(MushroomInput.text));
		PlayerPrefs.SetInt("Time Limit", int.Parse(TimeInput.text));
		if(RToggle.isOn){
			PlayerPrefs.SetInt("Right Click", 1);
		}else{
			PlayerPrefs.SetInt("Right Click", 0);
		}
		PlayerPrefs.Save();
	}

	public void suivant1(){
		PlayerPrefs.SetFloat("Q1", scr1.value);
		PlayerPrefs.Save();
	}
	public void suivant2(){
		PlayerPrefs.SetFloat("Q2", scr2.value);
		PlayerPrefs.Save();
	}
	public void suivant3(){
		PlayerPrefs.SetFloat("Q3", scr3.value);
		PlayerPrefs.Save();
	}
	public void suivant4(){
		PlayerPrefs.SetFloat("Q4", scr4.value);
		PlayerPrefs.Save();
	}
	public void suivant5(){
		PlayerPrefs.SetFloat("Q5", scr5.value);
		PlayerPrefs.Save();
	}
	public void suivant6(){
		PlayerPrefs.SetFloat("Q6", scr6.value);
		PlayerPrefs.Save();
	}
	public void suivant7(){
		PlayerPrefs.SetFloat("Q7", scr7.value);
		PlayerPrefs.Save();
	}
	public void suivant8(){
		PlayerPrefs.SetFloat("Q8", scr8.value);
		PlayerPrefs.Save();
	}
	public void suivant9(){
		PlayerPrefs.SetFloat("Q9", scr9.value);
		PlayerPrefs.Save();
	}
	public void suivant10(){
		PlayerPrefs.SetFloat("Q10", scr10.value);
		PlayerPrefs.Save();
	}
	public void suivant11(){
		PlayerPrefs.SetFloat("Q11", scr11.value);
		PlayerPrefs.Save();
	}
	public void suivant12(){
		PlayerPrefs.SetFloat("Q12", scr12.value);
		PlayerPrefs.Save();
	}
	public void suivant13(){
		PlayerPrefs.SetFloat("Q13", scr13.value);
		PlayerPrefs.Save();
	}
	public void suivant14(){
		PlayerPrefs.SetFloat("Q14", scr14.value);
		PlayerPrefs.Save();
	}
	public void suivant15(){
		PlayerPrefs.SetFloat("Q15", scr15.value);
		PlayerPrefs.Save();
	}
	public void suivant16(){
		PlayerPrefs.SetFloat("Q16", scr16.value);
		PlayerPrefs.Save();
	}
	public void suivant17(){
		PlayerPrefs.SetFloat("Q17", scr17.value);
		PlayerPrefs.Save();
	}
	public void suivant18(){
		PlayerPrefs.SetFloat("Q18", scr18.value);
		PlayerPrefs.Save();
	}

	public void PlayGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
