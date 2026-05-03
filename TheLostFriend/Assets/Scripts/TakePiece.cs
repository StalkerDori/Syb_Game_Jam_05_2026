using UnityEngine;

public class TakePiece : MonoBehaviour
{
    SpriteRenderer sprite;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        FindPieces.countFindPieces++;
        darkSprite.dark = true;
        Destroy(gameObject);
    }
    private void Update()
    {
        if (Arrow.imHere)
            Invoke("Act", 2f);
        else
            Invoke("Disact", 2f);
    }
    void Act()
    {
        sprite.enabled = true;
    }
    void Disact()
    {
        sprite.enabled = false;
    }
}
