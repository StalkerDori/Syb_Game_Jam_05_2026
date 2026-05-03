using UnityEngine;

public class Tumba : MonoBehaviour
{
    Animator anime;
    private bool on;
    private void OnMouseDown()
    {
        anime = GetComponent<Animator>();
        anime.SetBool("open", true);
        Invoke("Get", 2f);
    }
    void Get()
    {
        if (!on)
        {
            FindPieces.countFindPieces++;
            darkSprite.dark = true;
            on = true;
        }
    }
}
