using UnityEngine;

public class TakeObj : MonoBehaviour
{
    public GameObject objInInv;
    SpriteRenderer sprite;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    private void OnMouseDown()
    {
        objInInv.SetActive(true);
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
