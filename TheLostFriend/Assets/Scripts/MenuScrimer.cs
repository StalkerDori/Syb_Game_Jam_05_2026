using UnityEngine;

public class MenuScrimer : MonoBehaviour
{
    AudioSource m_AudioSource;
    public AudioClip clip;
    public GameObject O;
    bool one;
    void Start()
    {
        O.SetActive(false);
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.clip = clip;
    }

    private void OnMouseDown()
    {
        if (!one)
        {
            m_AudioSource.Play();
            O.SetActive(true);
            Invoke("Stop", 2f);
        }
    }
    void Stop()
    {
        one = true;
    }
}
