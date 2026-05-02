using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsMenu : MonoBehaviour
{
    public GameObject info;
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Info()
    {
        info.SetActive(true);
    }
    public void Back()
    {
        info.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
