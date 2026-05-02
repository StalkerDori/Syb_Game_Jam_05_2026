using UnityEngine;

public class FiveCubes : MonoBehaviour
{
    int j;
    public int myIcon;
    private bool trueIcon;
    public GameObject[] icon;
    void Start()
    {
        j = Random.Range(0, icon.Length);
        icon[j].SetActive(true);
    }

    // Update is called once per frame
    private void Update()
    {
        if (!trueIcon && myIcon == j)
        {
            FiveCubesManager.fiveCubecCount++;
            trueIcon = true;
        }
        if (trueIcon && myIcon != j)
        {
            FiveCubesManager.fiveCubecCount--;
            trueIcon = false;
        }
    }
    void OnMouseDown()
    {
        if (!FiveCubesManager.openDoor)
        {
            if (j < icon.Length - 1)
                j++;
            else
                j = 0;

            Disactive();
            icon[j].SetActive(true);
        }
    }
    void Disactive()
    {
        for (int i = 0; i < icon.Length; i++)
        {
            icon[i].SetActive(false);
        }
    }
}
