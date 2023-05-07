using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip bossMusic;
    [SerializeField]
    private AudioClip endMusic;
    public float speedLerp = 0.001f;
    private bool canLerp = true;
    private bool isEndLerp = false;


    private void Start()
    {
        StartCoroutine(FadeIn());
    }


    public IEnumerator ChangeSong(bool isBoss)
    {
        if (canLerp)
        {
            canLerp = false;
            while (audioSource.volume > 0)
            {
                if (!isEndLerp)
                    audioSource.volume -= speedLerp * 2 * Time.deltaTime;
                yield return null;
            }
            if (isBoss)
            {
                audioSource.clip = bossMusic;
            }
            else
            {
                audioSource.clip = endMusic;
            }

            audioSource.Play();
            while (audioSource.volume < 1)
            {
                if (!isEndLerp)
                    audioSource.volume += speedLerp * 2 * Time.deltaTime; 
                yield return null;
            }
            canLerp = true;
        }
    }

    public IEnumerator FadeOut()
    {
        isEndLerp = true;
        while (audioSource.volume > 0)
        {
            audioSource.volume -= speedLerp * 8 * Time.deltaTime;
            yield return null;
        }
    }

    public IEnumerator FadeIn()
    {
        while (audioSource.volume < 1)
        {
            audioSource.volume += speedLerp  * Time.deltaTime;
            yield return null;
        }
    }
}
