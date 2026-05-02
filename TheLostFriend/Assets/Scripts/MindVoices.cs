using TMPro;
using UnityEngine;

public class MindVoices : MonoBehaviour
{
    public TextMeshProUGUI mind;
    public string[] texts;
    Color textColor;
    void Start()
    {
        textColor.a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        mind.color = textColor;
        mind.text = texts[0];
    }
}
