using UnityEngine;

public class FindPieces : MonoBehaviour
{
    public GameObject[] pieces;
    public static float countFindPieces;
    public static bool eleven;
    void Start()
    {
        eleven = false;
        countFindPieces = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (countFindPieces == 11)
            eleven = true;
    }
}
