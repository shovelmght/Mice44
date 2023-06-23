using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicManagerWizard : MonoBehaviour
{
    [SerializeField]
    private AudioMixer mixerAudio;
    [SerializeField]
    private AudioSource music;
    [SerializeField]
    private AudioClip menuMusic;
    [SerializeField]
    private AudioClip LevelMusic;
    public static MusicManagerWizard instance;
    public float speedLerpFadeIn;
    public float speedLerpFadeOut;
    public float maxVolume;
    public float minVolume;
    public float LevelMusicVolume;
    public float MenuMusicVolume;
    private bool isFadeOut;
    private bool flipFlap;

    private void Awake()
    {
        MakeSingleton();
    }

    public MusicManagerWizard MakeSingleton()
    {
        if (instance == null)
        {
            instance = this;
        }

        return instance;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeIn());
    }

    public IEnumerator FadeOut()
    {
        float volume;
        mixerAudio.GetFloat("Master", out volume);
        isFadeOut = true;
        while (volume > minVolume)
        {
            mixerAudio.SetFloat("Master", volume - speedLerpFadeOut * Time.deltaTime);
            mixerAudio.GetFloat("Master", out volume);
            yield return null;
        }
        GameManagerWizardAndKnight.instance.SetUIScore(true);
        isFadeOut = false;
    }

    public IEnumerator FadeIn()
    {
        float volume;
        mixerAudio.GetFloat("Master", out volume);
        while (volume < maxVolume)
        {
            if (!isFadeOut)
            {
                mixerAudio.SetFloat("Master", volume + speedLerpFadeIn * Time.deltaTime);
                mixerAudio.GetFloat("Master", out volume);

                yield return null;
            }
            else
            {
                break;
            }
        }
    }
    public void ChangeSong()
    {
        if (flipFlap)
        {
            flipFlap = false;
            music.clip = LevelMusic;
            music.volume = LevelMusicVolume;
        }
        else
        {
            flipFlap = true;
            music.clip = menuMusic;
            music.volume = MenuMusicVolume;
        }
        music.Play();
        StartCoroutine(FadeIn());
    }

}
