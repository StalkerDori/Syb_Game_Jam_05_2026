using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{
    AudioSource m_AudioSource;
    public AudioClip clip;
    public Slider slider;
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider != null)
        {
            if (slider.value > 80 && slider.value < 85)
            {
                if (!m_AudioSource.isPlaying && Arrow.imHere)
                    Invoke("Play", 0.75f);
            }
            else
            {
                m_AudioSource.Stop();
            }
        }
    }
    void Play()
    {
        m_AudioSource.Play();
    }
}
