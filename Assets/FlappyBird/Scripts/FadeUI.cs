using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeUI : MonoBehaviour
{
    [SerializeField]
    private bool isBlack;       //Check if this object is black
    [SerializeField]
    private float lerpDuration = 1.11f;        //time of lerp
    [SerializeField]
    private float startValue = 0;         // is the normal transparence of UI
    [SerializeField]
    private float endValue = 1.1f;           // is the end value of tranparance want lerp
    [SerializeField]
    private float valueToLerp = 1;              // is the value to lerp
    [SerializeField]
    private bool IsEnterCave;       //Check if this object is Loose of Win screen
    private Canvas canvas;
    private Image image;
    public bool isFadeOut = false;


    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponentInParent<Canvas>();
        image = GetComponent<Image>();     // get Sprite Renderer component
        if (isFadeOut)
        {
            valueToLerp = 0;
        }

    }

    private void Update()
    {
        if(!isFadeOut)
        {
            image.color = new Color(0, 0, 0, valueToLerp);   // set transparence of UI and color
            valueToLerp -= 0.01f;
            if (valueToLerp < 0)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            image.color = new Color(0, 0, 0, valueToLerp);   // set transparence of UI and color
            valueToLerp += 0.01f;



            if (valueToLerp > 1)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("MainArcade");
            }
        }

    }


    // Blend UI tranparence to visible
    public IEnumerator Lerp(bool isRevert)
    {
        if (IsEnterCave)
            yield return new WaitForSeconds(0.75f);

        canvas.sortingOrder = 1;   //// Change "Layer" for not interfer with UI button

        float timeElapsed = 0;             // set timeElapse to 0
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);   //lerp fonction
            timeElapsed += Time.deltaTime;   // The completion time in seconds since the last frame (Read Only).
            yield return null;     // wait for the next frame and continue execution from this line
            if (!isBlack)
            {
                image.color = new Color(1, 1, 1, valueToLerp);   // set transparence of UI and color
            }
            else
            {
                image.color = new Color(0, 0, 0, valueToLerp);   // set transparence of sprite
            }
            if (isRevert)
                StartCoroutine(RevertLerp());
        }
    }

    // Blend UI tranparence to invisible
    public IEnumerator RevertLerp()
    {
        float timeElapsed = 0;             // set timeElapse to 0
        while (timeElapsed < lerpDuration)
        {
            Debug.Log(timeElapsed);

            valueToLerp = Mathf.Lerp(endValue, startValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;   // The completion time in seconds since the last frame (Read Only).
            yield return null;   // wait for the next frame and continue execution from this line

            if (isBlack)
            {
                image.color = new Color(0, 0, 0, valueToLerp);   // set transparence of sprite

            }
            else
            {
                image.color = new Color(valueToLerp, valueToLerp, valueToLerp, 1);   // set transparence of UI and color
            }
        }
        canvas.sortingOrder = 0;  // Change "Layer" for not interfer with UI button
    }
}
