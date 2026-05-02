using UnityEngine;

public class BlockMovingManager : MonoBehaviour
{
    public GameObject mainBlock, end;
    public static bool blockMoveCompleted;
    private bool piece;
    void Start()
    {
        blockMoveCompleted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (mainBlock != null)
        {
            float distance = Vector3.Distance(mainBlock.transform.localPosition, end.transform.localPosition);

            if (distance < 1f)
            {
                blockMoveCompleted = true;
            }
        }

        if (blockMoveCompleted && !piece)
        {
            FindPieces.countFindPieces++;
            Destroy(mainBlock);
            piece = true;
        }
    }
}
