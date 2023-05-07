using System.Collections;
using UnityEngine;

public class FlashingJoystick : MonoBehaviour
{
    [SerializeField]
    private Light lighComponent;
    public float delayFlash;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FlashingRed());
    }

    IEnumerator FlashingRed()
    {
        lighComponent.enabled = false;
        yield return new WaitForSeconds(delayFlash);
        lighComponent.enabled = true;
        yield return new WaitForSeconds(delayFlash);
        StartCoroutine(FlashingRed());
    }
}
