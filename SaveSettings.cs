using System.Collections;
using System.Globalization;
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
		PlayerPrefs.SetString("Q1", scr1.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant2(){
		PlayerPrefs.SetString("Q2", scr2.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant3(){
		PlayerPrefs.SetString("Q3", scr3.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant4(){
		PlayerPrefs.SetString("Q4", scr4.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant5(){
		PlayerPrefs.SetString("Q5", scr5.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant6(){
		PlayerPrefs.SetString("Q6", scr6.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant7(){
		PlayerPrefs.SetString("Q7", scr7.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant8(){
		PlayerPrefs.SetString("Q8", scr8.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant9(){
		PlayerPrefs.SetString("Q9", scr9.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant10(){
		PlayerPrefs.SetString("Q10", scr10.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant11(){
		PlayerPrefs.SetString("Q11", scr11.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant12(){
		PlayerPrefs.SetString("Q12", scr12.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant13(){
		PlayerPrefs.SetString("Q13", scr13.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant14(){
		PlayerPrefs.SetString("Q14", scr14.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant15(){
		PlayerPrefs.SetString("Q15", scr15.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant16(){
		PlayerPrefs.SetString("Q16", scr16.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant17(){
		PlayerPrefs.SetString("Q17", scr17.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}
	public void suivant18(){
		PlayerPrefs.SetString("Q18", scr18.value.ToString("G", CultureInfo.InvariantCulture));
		PlayerPrefs.Save();
	}

	public void PlayGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
