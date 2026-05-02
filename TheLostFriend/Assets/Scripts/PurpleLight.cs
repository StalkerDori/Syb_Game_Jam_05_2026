using UnityEngine;

public class PurpleLight : MonoBehaviour
{
    public GameObject purple, uzor;
    int l;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            l++;
        }

        if (l > 1)
            l = 0;

        if (l == 0)
        {
            uzor.SetActive(false);
            purple.SetActive(false);
        }
        else
        {
            uzor.SetActive(true);
            purple.SetActive(true);
        }
    }
}
