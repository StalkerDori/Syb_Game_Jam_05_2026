using UnityEngine;

public class BlockMovingManager : MonoBehaviour
{
    public GameObject mainBlock, end;
    public static bool blockMoveCompleted;
    void Start()
    {
        blockMoveCompleted = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(mainBlock.transform.localPosition, end.transform.localPosition);

        if (distance < 0.1f)
        {
            blockMoveCompleted = true;
            Debug.Log(blockMoveCompleted);
        }
    }
}
