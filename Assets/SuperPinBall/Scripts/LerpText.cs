using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LerpText : MonoBehaviour
{
    private float lerpDuration = 1.11f;
    private float startValue = 0;
    private float endValue = 1.1f;
    private float valueToLerp = 1;
    private Text txt;

    void Start()
    {
        txt = GetComponent<Text>();
    }

    public IEnumerator Lerp()
    {
        float timeElapsed = 0;
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
            txt.color = new Color(0, 0, 0, valueToLerp);
        }
    }

    public IEnumerator RevertLerp()
    {

        float timeElapsed = 0;
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(endValue, startValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;

            txt.color = new Color(0, 0, 0, valueToLerp);
        }
    }
}

