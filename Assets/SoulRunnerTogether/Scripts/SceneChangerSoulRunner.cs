using System.Collections;
using System.Collections.Generic;
using LesserKnown.Audio;
using LesserKnown.Public;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerSoulRunner : MonoBehaviour
{
    [SerializeField]
    Fade blackScreen;
    [SerializeField]
    private AudioManager musicManagerSoulRunner;
    public float delayLerp;


    public IEnumerator ChangeScene(string sceneName)
    {
        yield return new WaitForSeconds(delayLerp);
        StartCoroutine(musicManagerSoulRunner.FadeOut());
        StartCoroutine(blackScreen.Lerp(true));
        while (!blackScreen.LerpIsEnd())
        {
            yield return null;
        }
        SceneManager.LoadScene(sceneName);
    }


    public void ReturnMainScene(string sceneName)
    {
        PublicVariables.ResetAllVariable();
        StartCoroutine(ChangeScene(sceneName));
    }
}

