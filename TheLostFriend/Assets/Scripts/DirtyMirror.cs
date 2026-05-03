using UnityEngine;

public class DirtyMirror : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (InvManager.tryapka)
            Destroy(gameObject);
    }
}
