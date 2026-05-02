using UnityEngine;

public class PictureManager : MonoBehaviour
{
    public static int countPieces;
    public static bool winPicture;
    void Start()
    {
        winPicture = false;
        countPieces = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (countPieces == 11)
            winPicture = true;

        if (winPicture)
        {

        }
    }
}
