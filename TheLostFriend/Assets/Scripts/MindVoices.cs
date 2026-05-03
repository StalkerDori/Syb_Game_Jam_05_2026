using TMPro;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class MindVoices : MonoBehaviour
{
    float timer;
    public TextMeshProUGUI mind;
    public string[] startMessages, brain, final;
    public string picture;
    Color textColor;
    void Start()
    {
        textColor.a = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        mind.color = textColor;

        if (timer < 5)
        {
            mind.text = startMessages[0];
        }
        if (timer > 5 && timer < 10)
        {
            mind.text = startMessages[1];
        }
        if (timer > 10 && timer < 15)
        {
            mind.text = startMessages[2];
        }
        else
            mind.text = "";
    }
}
