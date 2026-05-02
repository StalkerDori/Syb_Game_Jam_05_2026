using UnityEngine;

public class TakePiece : MonoBehaviour
{
    MeshRenderer rend;
    //SpriteRenderer sprite;
    private void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }
    private void OnMouseDown()
    {
        FindPieces.countFindPieces++;
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
        rend.enabled = true;
    }
    void Disact()
    {
        rend.enabled = false;
    }
}
