using UnityEngine;

public class Compteur : MonoBehaviour
{
    private int cmp;

    // Start is called before the first frame update
    void Start()
    {
        cmp = 0;
    }

    public void Increment()
    {
        cmp++;
    }

    public int Query()
    {
        return cmp;
    }

}
