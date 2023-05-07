using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationUi_W : MonoBehaviour
{
    private float startValue = 200;         // is the normal size of UI
    private float endValue = 300;           // is the end value of size want lerp
    private float valueToLerp;              // is the value to lerp

    private SpriteRenderer spriteR;

    [SerializeField]
    private float lerpDuration = 0.15f;        //time of lerp

    private void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
    }

    // Lerp Scale
    public IEnumerator Lerp()
    {
        float timeElapsed = 0;            // Reset timeElapse 
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);   //lerp fonction
            timeElapsed += Time.deltaTime;   // The completion time in seconds since the last frame (Read Only).
            yield return null;   // wait for the next frame and continue execution from this line
            transform.localScale = new Vector3(valueToLerp, valueToLerp/200, 0);     // set  size modification

        }

        StartCoroutine(LerpRevert());     // call IEnumator revert for return size and position nomal


    }

    // invert Lerp Scale
    private IEnumerator LerpRevert()
    {
        float timeElapsed = 0;     // Reset timeElapse 
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(endValue, startValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;  // // The completion time in seconds since the last frame (Read Only).
            yield return null; // wait for the next frame and continue execution from this line
            transform.localScale = new Vector3(valueToLerp, valueToLerp / 200, 0);     // set  size modification



        }

        spriteR.enabled = false;
    }
}
