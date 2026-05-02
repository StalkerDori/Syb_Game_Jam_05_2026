using UnityEngine;

public class RadioStart : MonoBehaviour
{
    AudioSource m_AudioSource;
    public AudioClip clip;
    public GameObject s;
    private bool on;
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            s.SetActive(true);
            if (!m_AudioSource.isPlaying)
                m_AudioSource.Play();
        }
        else
        {
            s.SetActive(false);
            m_AudioSource.Stop();
        }

        if (!Arrow.imHere)
            on = false;
    }
    private void OnMouseDown()
    {
        Invoke("On", 2f);
    }

    void On()
    {
        on = true;
    }
}
