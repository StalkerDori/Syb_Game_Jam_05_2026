using UnityEngine;

public class FiveCubesManager : MonoBehaviour
{
    AudioSource a;
    public AudioClip clip;
    public GameObject door, doorRig;
    public static int fiveCubecCount;
    public static bool openDoor;
    bool stop;
    void Start()
    {
        a = GetComponent<AudioSource>();
        a.clip = clip;
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
            {
                door.transform.RotateAround(doorRig.transform.position, -transform.up, 0.05f);
                if (!a.isPlaying)
                {
                    a.Play();
                    Invoke("Stope", 3f);
                }
            }

            Invoke("Stop", 3f);
        }

    }
    void Stop()
    {
        stop = true;
    }
    void Stope()
    {
        a.Stop();
    }
}
