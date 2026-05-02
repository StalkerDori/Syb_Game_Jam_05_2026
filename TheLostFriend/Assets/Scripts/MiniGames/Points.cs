using UnityEngine;

public class Points : MonoBehaviour
{
    public Camera cam;
    public bool truePoint;
    MeshRenderer rend;

    public Color trailColor;
    public float distanceFromCamera = 5; // Расстояние от камеры
    public float startWidth; // Начальная ширина следа
    public float endWidth; // Конечная ширина (может быть 0 для мгновенного исчезновения)
    public float trailTime; // Время жизни следа

    Transform trailTransform;

    public static bool startConnect;
    private bool me;
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        GameObject trailObj = new GameObject("Mouse Trail");
        trailTransform = trailObj.transform;
        TrailRenderer trail = trailObj.AddComponent<TrailRenderer>();
        //trail.time = -1f; // Начальное время жизни следа
        MoveTrailToCursor(Input.mousePosition);
        trailTime = 5f;
        trail.time = trailTime;
        trail.startWidth = startWidth;
        trail.endWidth = endWidth;
    }

    // Update is called once per frame
    void Update()
    {
        if (startConnect)
        {
            MoveTrailToCursor(Input.mousePosition);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Invoke("Check", 0.1f);
        }

        if (!truePoint && me)
        {
            PointsManager.pointsCount = -100;
        }
    }
    void MoveTrailToCursor(Vector3 screenPosition)
    {
        trailTransform.position = cam.ScreenToWorldPoint(new Vector3(screenPosition.x, screenPosition.y, distanceFromCamera));
    }
    private void OnMouseDown()
    {
        if (!PointsManager.pointsComplete)
        {
            trailTime = 5f;
            startConnect = true;
            me = true;
        }
    }
    private void OnMouseEnter()
    {
        if (startConnect)
        {
            me = true;

            if (truePoint && me)
            {
                PointsManager.pointsCount++;
            }
        }
    }
    private void OnMouseUp()
    {
        trailTime = 0f;
        startConnect = false;
    }
    void Check()
    {
        if (!PointsManager.pointsComplete)
        {
            PointsManager.pointsCount = 0;
            me = false;
        }
        else
        {
            if (me)
            {
                rend.material.color = Color.red;
            }
        }
    }
}
