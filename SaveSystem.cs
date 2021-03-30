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
                            + FieldOfView.saveListDataChampisInView.Remove(FieldOfView.saveListDataChampisInView.Length -1) + "],"
                            + ItemCounter.saveListData.Remove(ItemCounter.saveListData.Length - 1) + "],"
                            + "\"Nom\":[\"" + PlayerPrefs.GetString("Player Name") + "\"],"
                            + "\"Nb champignons\":[" + PlayerPrefs.GetInt("Number Mushroom") + "],"
                            + "\"Temps\":[" + PlayerPrefs.GetInt("Time Limit")  + "],"
                            + "\"Q1\":[" + PlayerPrefs.GetString("Q1")  + "],"
                            + "\"Q2\":[" + PlayerPrefs.GetString("Q2")  + "],"
                            + "\"Q3\":[" + PlayerPrefs.GetString("Q3")  + "],"
                            + "\"Q4\":[" + PlayerPrefs.GetString("Q4")  + "],"
                            + "\"Q5\":[" + PlayerPrefs.GetString("Q5")  + "],"
                            + "\"Q6\":[" + PlayerPrefs.GetString("Q6")  + "],"
                            + "\"Q7\":[" + PlayerPrefs.GetString("Q7")  + "],"
                            + "\"Q8\":[" + PlayerPrefs.GetString("Q8")  + "],"
                            + "\"Q9\":[" + PlayerPrefs.GetString("Q9")  + "],"
                            + "\"Q10\":[" + PlayerPrefs.GetString("Q10")  + "],"
                            + "\"Q11\":[" + PlayerPrefs.GetString("Q11")  + "],"
                            + "\"Q12\":[" + PlayerPrefs.GetString("Q12")  + "],"
                            + "\"Q13\":[" + PlayerPrefs.GetString("Q13")  + "],"
                            + "\"Q14\":[" + PlayerPrefs.GetString("Q14")  + "],"
                            + "\"Q15\":[" + PlayerPrefs.GetString("Q15")  + "],"
                            + "\"Q16\":[" + PlayerPrefs.GetString("Q16")  + "],"
                            + "\"Q17\":[" + PlayerPrefs.GetString("Q17")  + "],"
                            + "\"Q18\":[" + PlayerPrefs.GetString("Q18")  + "]}";
        File.WriteAllText(Application.dataPath + "/save.json", saveListData );

    }
}
