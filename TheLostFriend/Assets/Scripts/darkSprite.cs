using UnityEngine;

public class darkSprite : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public static bool dark;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dark)
        {
            spriteRenderer.color = new Color(spriteRenderer.color.r - 0.025f, spriteRenderer.color.g - 0.025f, spriteRenderer.color.b - 0.025f, 1);
            dark = false;
        }
    }
}
