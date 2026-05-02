using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public static bool pointsComplete;
    public static float pointsCount;
    void Start()
    {
        pointsComplete = false;
        pointsCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (pointsComplete)
        {

        }
        if (pointsCount == 15)
            pointsComplete = true;
    }
}
