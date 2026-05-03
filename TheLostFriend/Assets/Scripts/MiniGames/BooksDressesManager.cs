using UnityEngine;

public class BooksDressesManager : MonoBehaviour
{
    public GameObject hiddenPiece1, hiddenPiece2;
    public static bool dressesComplete, booksComplete;
    public static float dressesCount, booksCount;

    bool dr, bo;
    void Start()
    {
        dressesComplete = false;
        booksComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (booksCount == 5)
            booksComplete = true;

        if (dressesCount == 4)
            dressesComplete = true;

        if (!dr && dressesComplete)
        {
            hiddenPiece2.SetActive(true);
                FindPieces.countFindPieces++;
                darkSprite.dark = true;
                dr = true;
        }

        if (!bo && booksComplete)
        {
            hiddenPiece1.SetActive(true);
                FindPieces.countFindPieces++;
                darkSprite.dark = true;
                bo = true;
        }
    }
}
