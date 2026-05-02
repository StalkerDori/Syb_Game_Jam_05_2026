using UnityEngine;
using UnityEngine.UI;

public class RadioRed : MonoBehaviour
{
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        if (slider != null)
            transform.localPosition = new Vector3 (slider.value / 50 - 3.5f, transform.localPosition.y, transform.localPosition.z);
    }
}
