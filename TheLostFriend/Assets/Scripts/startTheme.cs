using UnityEngine;

public class startTheme : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("Play", 3f);
    }

    private void Update()
    {
        if (TV.tv)
        {
            audioSource.volume = 0;
        }
        else
        {
            audioSource.volume = 0.8f;
        }
    }

    void Play()
    {
        audioSource.Play();
    }
}
