using System.Collections;
using System.Collections.Generic;
using LesserKnown.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField]
    Fade blackScreen;
    [SerializeField]
    private ReminderPosPlayer posPlayer;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private MusicManager musicManager;
    [SerializeField]
    private AudioManager musicManagerSoulRunner;
    public float delayLerp;

    private void Start()
    {
        posPlayer = GameObject.FindGameObjectWithTag("Reminder").GetComponent<ReminderPosPlayer>();
    }

    public IEnumerator ChangeScene(string sceneName)
    {
        posPlayer.GetPositionPlayer();
        yield return new WaitForSeconds(delayLerp);
        StartCoroutine(musicManager.FadeOut());
        StartCoroutine(blackScreen.Lerp(true));
        while(!blackScreen.LerpIsEnd())
        {
            yield return null;
        }
        SceneManager.LoadScene(sceneName);
    }

    public IEnumerator ChangeToMainScene()
    {
        yield return new WaitForSeconds(delayLerp);
        StartCoroutine(musicManagerSoulRunner.FadeOut());
        StartCoroutine(blackScreen.Lerp(true));
        while (!blackScreen.LerpIsEnd())
        {
            yield return null;
        }
        SceneManager.LoadScene("MainArcadeScene");
    }

    public IEnumerator AddReminderPosPlayerRef()
    {
        yield return new WaitForSeconds(0.2f);
        posPlayer = GameObject.FindGameObjectWithTag("Reminder").GetComponent<ReminderPosPlayer>();
    }

    public void ReturnMainScene()
    {
        StartCoroutine(ChangeToMainScene());
    }
}
