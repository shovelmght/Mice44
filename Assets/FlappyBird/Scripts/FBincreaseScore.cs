using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBincreaseScore : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("FBscore", PlayerPrefs.GetInt("FBscore") + 1);
            audioSource.Play();
            if (PlayerPrefs.GetInt("FBscore") % 20 == 0)
            {
                
            }
        }
    }
}
