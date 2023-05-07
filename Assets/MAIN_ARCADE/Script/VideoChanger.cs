using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoChanger : MonoBehaviour
{
    [SerializeField]
    private GameObject endScreen;
    public VideoPlayer vid;
    public VideoClip myclip;
    public float delayChVideo;

    public void ChangeVideo()
    {
        endScreen.SetActive(true);

        StartCoroutine(delayChangeVideo());
    }

    IEnumerator delayChangeVideo()
    {
        yield return new WaitForSeconds(delayChVideo);
        gameObject.SetActive(false);
    }
}
