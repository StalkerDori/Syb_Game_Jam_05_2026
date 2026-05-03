using UnityEngine;

public class HiddenPiece : MonoBehaviour
{
    bool stop;
    void Update()
    {
        if (!stop)
            transform.Translate(0, -Time.deltaTime / 5, 0);

        Invoke("Stop", 2f);
    }
    void Stop()
    {
        stop = true;
        Invoke("D", 1f);
    }
    void D()
    {
        Destroy(gameObject);
    }
}
