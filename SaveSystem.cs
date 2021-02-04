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
        string saveListData = SpawnScript.saveListDataChampis.Remove(Player.saveListData.Length - 1) + "],"
                            + Player.saveListData.Remove(Player.saveListData.Length - 1) + "],"
                            + ItemCounter.saveListData.Remove(ItemCounter.saveListData.Length - 1) + "],"
                            + "\"Nom\":[\"" + PlayerPrefs.GetString("Player Name") + "\"],"
                            + "\"Nb champignons\":[" + PlayerPrefs.GetInt("Number Mushroom") + "],"
                            + "\"Temps\":[" + PlayerPrefs.GetInt("Time Limit")  + "]}";
        File.WriteAllText(Application.dataPath + "/save.json", saveListData );

    }
}
