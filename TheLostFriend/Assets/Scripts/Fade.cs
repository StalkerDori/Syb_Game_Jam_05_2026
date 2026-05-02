using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Fade : MonoBehaviour
{
    private Light2D light2D;
    public static bool faded;
    private bool lightt;
    public static float staticLerpTime;
    public float lerpTime;
    private float timerFaded;
    void Start()
    {
        timerFaded = lerpTime;
        staticLerpTime = lerpTime;
        light2D = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        light2D.intensity = timerFaded;
        Faded();
    }
    void Faded()
    {
        if (faded)
        {
            if (timerFaded > 0 && !lightt)
                timerFaded -= Time.deltaTime;

            if (timerFaded <= 0)
                lightt = true;

            if (lightt)
                Invoke("Lightt", lerpTime);
        }
    }
    void Lightt()
    {
        if (lightt && timerFaded < lerpTime)
            timerFaded += Time.deltaTime;

        if (lightt && timerFaded >= lerpTime)
        {
            timerFaded = lerpTime;
            lightt = false;
            faded = false;
        }
    }
}
