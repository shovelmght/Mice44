using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagerPinBall : MonoBehaviour
{
    public PinBallGameManager gameManager;
    public AudioSource audioSourceMusic;
    [SerializeField] private AudioClip[] Music;
    public float speedFadeIN;
    public float maxVolume;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeIn());
        gameManager = PinBallGameManager.FindObjectOfType<PinBallGameManager>();

        if(gameManager.GetisMenuScene())
        {
            audioSourceMusic.loop = true;
            audioSourceMusic.clip = Music[0];
            audioSourceMusic.Play();
        }
        else if(gameManager.GetIsSceneScore())
        {
            audioSourceMusic.loop = true;
            audioSourceMusic.clip = Music[2];
            audioSourceMusic.Play();
        }
        else
        {
            audioSourceMusic.loop = true;
            audioSourceMusic.clip = Music[1];
            audioSourceMusic.Play();
        }
    }

    public void FadeMusic()
    {

    }

    public IEnumerator FadeOut()
    {
        float startVolume = audioSourceMusic.volume;

        while (audioSourceMusic.volume > 0)
        {
            audioSourceMusic.volume -= startVolume * Time.deltaTime ;

            yield return null;
        }
        audioSourceMusic.Stop();

    }
    public IEnumerator FadeIn()
    {
        Debug.Log("1");
        Debug.Log("volume =" + audioSourceMusic.volume);

      
        while (audioSourceMusic.volume < maxVolume)
        {
            Debug.Log("2");
            Debug.Log("volume =" + audioSourceMusic.volume);
            audioSourceMusic.volume += speedFadeIN * Time.deltaTime;

            yield return null;
        }
        Debug.Log("3");
        Debug.Log("volume =" + audioSourceMusic.volume);
    }
}
