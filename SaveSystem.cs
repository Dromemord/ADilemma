using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveSystem
{

    public static void SavePlayer()
    {
        Debug.Log(PlayerPrefs.GetInt("Time Limit"));
        Debug.Log(PlayerPrefs.GetString("Player Name"));
        string saveListData = SpawnScript.saveListDataChampis.Remove(SpawnScript.saveListDataChampis.Length - 1) + "],"
                            + Player.saveListData.Remove(Player.saveListData.Length - 1) + "],"
                            + ItemCounter.saveListData.Remove(ItemCounter.saveListData.Length - 1) + "],"
                            + "\"Nom\":[\"" + PlayerPrefs.GetString("Player Name") + "\"],"
                            + "\"Nb champignons\":[" + PlayerPrefs.GetInt("Number Mushroom") + "],"
                            + "\"Temps\":[" + PlayerPrefs.GetInt("Time Limit")  + "]}"
                            + "\"Q1\":[" + PlayerPrefs.GetFloat("Q1")  + "]}"
                            + "\"Q2\":[" + PlayerPrefs.GetFloat("Q2")  + "]}"
                            + "\"Q3\":[" + PlayerPrefs.GetFloat("Q3")  + "]}"
                            + "\"Q4\":[" + PlayerPrefs.GetFloat("Q4")  + "]}"
                            + "\"Q5\":[" + PlayerPrefs.GetFloat("Q5")  + "]}"
                            + "\"Q6\":[" + PlayerPrefs.GetFloat("Q6")  + "]}"
                            + "\"Q7\":[" + PlayerPrefs.GetFloat("Q7")  + "]}"
                            + "\"Q8\":[" + PlayerPrefs.GetFloat("Q8")  + "]}"
                            + "\"Q9\":[" + PlayerPrefs.GetFloat("Q9")  + "]}"
                            + "\"Q10\":[" + PlayerPrefs.GetFloat("Q10")  + "]}"
                            + "\"Q11\":[" + PlayerPrefs.GetFloat("Q11")  + "]}"
                            + "\"Q12\":[" + PlayerPrefs.GetFloat("Q12")  + "]}"
                            + "\"Q13\":[" + PlayerPrefs.GetFloat("Q13")  + "]}"
                            + "\"Q14\":[" + PlayerPrefs.GetFloat("Q14")  + "]}"
                            + "\"Q15\":[" + PlayerPrefs.GetFloat("Q15")  + "]}"
                            + "\"Q16\":[" + PlayerPrefs.GetFloat("Q16")  + "]}"
                            + "\"Q17\":[" + PlayerPrefs.GetFloat("Q17")  + "]}"
                            + "\"Q18\":[" + PlayerPrefs.GetFloat("Q18")  + "]}";
        File.WriteAllText(Application.dataPath + "/save.json", saveListData );

    }
}
