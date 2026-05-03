using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject l, u, ultraLamp;
    bool vse;
    int y;
    private void OnMouseDown()
    {
        if (InvManager.lamp & !vse)
            l.SetActive(true);

        if (InvManager.pencil && l.activeSelf && !vse)
        {
            vse = true;;
            l.SetActive(false);
        }

        if (vse)
            y++;
    }
    private void Update()
    {
        if (vse)
        {
            if (y == 1)
            {
                u.SetActive(true);
                ultraLamp.SetActive(true);
            }
            else
            {
                u.SetActive(false);
                ultraLamp.SetActive(false);
            }

            if (y > 1)
                y = 0;
        }
    }
}
