using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public GameObject hiddenPiece;
    public static bool pointsComplete;
    public static float pointsCount;
    private bool one;
    void Start()
    {
        pointsComplete = false;
        pointsCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (pointsComplete && !one)
        {
            hiddenPiece.SetActive(true);
                FindPieces.countFindPieces++;
                darkSprite.dark = true;
                one = true;
        }
        if (pointsCount == 15 && Input.GetMouseButtonUp(0))
            pointsComplete = true;
    }
}
