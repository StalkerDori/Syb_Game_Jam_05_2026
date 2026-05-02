using UnityEngine;
using UnityEngine.UIElements;

public class ComeToMe : MonoBehaviour
{
    public bool room1, room2;
    Collider coll;
    public float x, y, z, q;
    public GameObject cam;
    public Camera cameraa;
    private Vector3 currentCamPos;
    void Start()
    {
        coll = GetComponent<Collider>();
        currentCamPos = new Vector3(0, -1, -10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Arrow.imHere && !Fade.faded && !room1 && !room2)
        {
            coll.enabled = true;
            Fade.faded = true;
            Invoke("GoBack", Fade.staticLerpTime);
        }
    }
    private void OnMouseDown()
    {
        if (!Fade.faded && !Arrow.imHere)
        {
            if (!room1 && !room2)
            {
                Arrow.imHere = true;
                currentCamPos = cam.transform.position;
            }
            else
            {
                if (room1)
                    currentCamPos = new Vector3(0, -1, -10);
                if (room2)
                    currentCamPos = new Vector3(0, -1, -35);
            }
            Fade.faded = true;
            Invoke("GoHere", Fade.staticLerpTime);
        }
    }
    private void GoHere()
    {
        cam.transform.position = new Vector3(x, y, z);

        if (!room1 && !room2)
        {
            coll.enabled = false;
            cameraa.orthographicSize = q;
        }
    }
    private void GoBack()
    {
        cam.transform.position = currentCamPos;
        Arrow.imHere = false;
        cameraa.orthographicSize = 4;
    }
}
