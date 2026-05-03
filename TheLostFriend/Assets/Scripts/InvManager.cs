using UnityEngine;

public class InvManager : MonoBehaviour
{
    public GameObject t, l, p, lp, c;
    public static bool tryapka, lamp, pencil, lastPiece, chocolate;

    public void Tryapka()
    {
        if (t.activeSelf)
        {
            Resett();
            tryapka = true;
        }
    }
    public void Lamp()
    {
        if (l.activeSelf)
        {
            Resett();
            lamp = true;
        }
    }
    public void Chocolate()
    {
        if (c.activeSelf)
        {
            Resett();
            chocolate = true;
        }
    }
    public void LastPiece()
    {
        if (lp.activeSelf)
        {
            Resett();
            lastPiece = true;
        }
    }
    public void Pencil()
    {
        if (p.activeSelf)
        {
            Resett();
            pencil = true;
        }
    }
    void Resett()
    {
        tryapka = false; lamp = false; pencil = false; chocolate = false; lastPiece = false;
    }
}
