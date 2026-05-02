using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrow : MonoBehaviour
{
    int i;
    public GameObject panel;
    public GameObject inventory;
    public static bool imHere;
    public GameObject cam;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !Arrow.imHere && !Fade.faded)
        {
            panel.SetActive(true);
        }

        if (i > 1)
            i = 0;

        if (i == 1)
        {
            if (inventory.transform.localPosition.x > 0)
                inventory.transform.Translate(-Time.deltaTime * 125, 0, 0);
        }
        else
        {
            if (inventory.transform.localPosition.x < 250)
                inventory.transform.Translate(Time.deltaTime * 125, 0, 0);
        }
    }

    public void LeftArrow()
    {
        if (!imHere && !Fade.faded)
        {
            Fade.faded = true;
            Invoke("RotLeft", Fade.staticLerpTime);
        }
    }
    public void RightArrow()
    {
        if (!imHere && !Fade.faded)
        {
            Fade.faded = true;
            Invoke("RotRight", Fade.staticLerpTime);
        }
    }
    public void ShowInv()
    {
        i++;
    }
    public void No()
    {
        panel.SetActive(false);
    }
    public void Yes()
    {
        SceneManager.LoadScene("Menu");
    }
    void RotLeft()
    {
        cam.transform.Rotate(0, -90, 0);
    }
    void RotRight()
    {
        cam.transform.Rotate(0, 90, 0);
    }
}

