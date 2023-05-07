using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlManagerScoreScn : MonoBehaviour
{
    public LerpUI blackScreen;
    public GameObject screenBlack;

    public void PlayButton()
    {
        StartCoroutine(ChangeScene());
    }

    public IEnumerator ChangeScene()
    {
        screenBlack.SetActive(true);
        StartCoroutine(blackScreen.Lerp(true));
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
