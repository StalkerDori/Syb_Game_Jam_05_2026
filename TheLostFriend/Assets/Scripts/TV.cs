using UnityEngine;
using UnityEngine.Video;

public class TV : MonoBehaviour
{
    VideoPlayer TVplayer;
    public static bool tv;
    public GameObject iconsTV;

    private void Start()
    {
        TVplayer = GetComponent<VideoPlayer>();
    }
    private void Update()
    {
        if (!Arrow.imHere)
            Stop();
    }
    private void OnMouseDown()
    {
        Invoke("PlayTV", 2f);
    }
    void Stop()
    {
        TVplayer.Stop();
        tv = false;
    }
    void PlayTV()
    {
        if (!TVplayer.isPlaying)
        {
            tv = true;
            TVplayer.Play();

            Invoke("Icon", Random.Range(5, 35));
            Invoke("Stop", 39f);
        }
    }
    void Icon()
    {
        iconsTV.SetActive(true);
        Invoke("StopIcon", 0.5f);
    }
    void StopIcon()
    {
        iconsTV.SetActive(false);
    }
}
