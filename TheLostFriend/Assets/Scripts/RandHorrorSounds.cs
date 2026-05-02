using UnityEngine;

public class RandHorrorSounds : MonoBehaviour
{
    AudioSource a;
    public AudioClip[] horror;
    float timer;
    int rand;
    void Start()
    {
        a = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > Random.Range(30, 60))
        {
            rand = Random.Range(0, horror.Length);
            a.clip = horror[rand];
            a.Play();
            timer = 0;
        }
    }
}
