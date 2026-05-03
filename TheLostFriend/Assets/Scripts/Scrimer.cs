using UnityEngine;

public class Scrimer : MonoBehaviour
{
    public GameObject scrimer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scrimer.activeSelf)
        {
            scrimer.transform.Translate(0, 0, -Time.deltaTime * 10);
            scrimer.transform.localScale = new Vector3(5 + Time.deltaTime * 5, 5 + Time.deltaTime * 5, transform.localScale.z);
        }

        if (PictureManager.countPieces == 12 && Input.GetKeyDown(KeyCode.Escape))
        {
            Invoke("Scr", 1.5f);
        }
    }
    void Scr()
    {
        scrimer.SetActive(true);
        Invoke("Stop", 9f);
    }
    void Stop()
    {
        scrimer.SetActive(false);
    }
}
