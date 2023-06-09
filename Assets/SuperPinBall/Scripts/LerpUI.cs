using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LerpUI : MonoBehaviour
{
    private float lerpDuration = 1.11f;
    private float startValue = 0;
    private float endValue = 1.1f;
    private float valueToLerp = 1;
    private Image image;
    void Start()
    {
        image = GetComponent<Image>();
    }

    public IEnumerator Lerp(bool isBlackScreen)
    {
        float timeElapsed = 0;
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
            if(isBlackScreen)
            {
                image.color = new Color(0, 0, 0, valueToLerp);
            }
            else
            {
                image.color = new Color(1, 1, 1, valueToLerp);
            }
        }
    }

    public IEnumerator RevertLerp(bool isBlackScreen)
    {
        yield return new WaitForSeconds(4);
        float timeElapsed = 0;
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(endValue, startValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
            image.color = new Color(valueToLerp, valueToLerp, valueToLerp, valueToLerp);
        }
        this.gameObject.SetActive(false);
    }

    public bool LerpIsEnd()
    {
        return valueToLerp >= endValue - 0.1f;
    }
}