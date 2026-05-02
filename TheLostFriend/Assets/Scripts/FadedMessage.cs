using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FadedMessage : MonoBehaviour
{
    Image startImage;
    public TextMeshProUGUI t;
    public Color B, W;
    void Start()
    {
        W.a = 1;
        B.a = 1;
        startImage = GetComponent<Image>();
    }
    private void Update()
    {
        Invoke("Trans", 3f);
    }
    void Trans()
    {
        startImage.color = B;
        t.color = W;
        B.a -= Time.deltaTime;
        W.a -= Time.deltaTime;

        if (startImage.color.a <= 0)
            Destroy(gameObject);
    }
}
