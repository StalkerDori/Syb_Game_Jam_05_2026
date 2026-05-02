using UnityEngine;

public class FiveCubesManager : MonoBehaviour
{
    public GameObject door, doorRig;
    public static int fiveCubecCount;
    public static bool openDoor;
    bool stop;
    void Start()
    {
        openDoor = false;
        fiveCubecCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (fiveCubecCount == 5)
            openDoor = true;

        if (openDoor)
        {
            if (!stop)
                door.transform.RotateAround(doorRig.transform.position, -transform.up, 0.05f);

            Invoke("Stop", 3f);
        }

    }
    void Stop()
    {
        stop = true;
    }
}
