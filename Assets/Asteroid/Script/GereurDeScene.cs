using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GereurDeScene : MonoBehaviour
{
    [SerializeField] Image fadeImage;
    [SerializeField] float FadeTime = 1f;

    void Start()
    {
        StartCoroutine(FadeIn(FadeTime));
    }

    public void ExitGame()
    {
        StartCoroutine(FadeOut(FadeTime));

        Invoke("LoadMainScene", FadeTime);
    }

    void LoadMainScene()
    {
        SceneManager.LoadScene("MainArcade");
    }

    IEnumerator FadeIn(float duration)
    {
        float startValue = fadeImage.color.a;
        float time = 0;

        while (time < duration)
        {
            
            fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, Mathf.Lerp(startValue, 0, time / duration));
            time += Time.deltaTime;
            yield return null;
        }
        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 0f);
        fadeImage.gameObject.SetActive(false);
    }

    IEnumerator FadeOut(float duration)
    {
        fadeImage.gameObject.SetActive(true);
        float startValue = fadeImage.color.a;
        float time = 0;

        while (time < duration)
        {
            fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, Mathf.Lerp(startValue, 1, time / duration));
            time += Time.deltaTime;
            yield return null;
        }

        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 1f);
    }
}
