using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPaddle : MonoBehaviour
{
    public Flipper paddle;
    public bool isRight;
    public AudioSource m_AudioSource;
    [SerializeField] private AudioClip[] sound;
    public PinBallGameManager gameManager;

    private void Start()
    {
        gameManager = PinBallGameManager.FindObjectOfType<PinBallGameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball") && isRight)
        {
            paddle.RightPaddle(isRight);
            PlayAudio();
        }

        if (other.gameObject.CompareTag("Ball") && !isRight)
        {
            paddle.RightPaddle(isRight);
            PlayAudio();
        }
    }

    private void PlayAudio()
    {
        if(!gameManager.GetisChangingScene())
        {
            m_AudioSource.pitch = Random.Range(1.7f, 2.2f);
            int n = Random.Range(1, 2);
            m_AudioSource.clip = sound[n];
            m_AudioSource.PlayOneShot(m_AudioSource.clip);
            sound[n] = sound[0];
            sound[0] = m_AudioSource.clip;
        }
    }
}
