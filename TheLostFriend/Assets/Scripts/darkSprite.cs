using UnityEngine;

public class darkSprite : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            spriteRenderer.color = new Color(spriteRenderer.color.r - 0.025f, spriteRenderer.color.g - 0.025f, spriteRenderer.color.b - 0.025f, 1);
        }
    }
}
