using UnityEngine;
using UnityEngine.UI;

public class ItemCounter : MonoBehaviour
{
    public Text counterText;
    public int counter = 0;
    Compteur compteur;

    public static string saveListData;
    private void Awake()
    {
        saveListData = "\"Score\":[";
        counterText.text = "0";
        compteur = GameObject.FindWithTag("Compteur").GetComponent<Compteur>();
    }

    private void FixedUpdate()
    {
        counter = compteur.Query();
        counterText.text = counter.ToString();
        saveListData += " " + counter.ToString() + ",";
    }
}
