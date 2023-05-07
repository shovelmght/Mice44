using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public PinBallGameManager gameManager;
    public DownSpring spring;
    public GameObject ball;
    private Vector3 StartScaleSpring;
    private float startPos;
    private float mintPos = 5;
    public float speed = 0.1f;
    public float speedRevert = 3f;
    private bool doOnce = false;
    private bool doOnceSound = true;
    public float force = 0;
    public float addForce = 0.3f;
    public float scaleSpring = 0.3f;
    private AudioSource m_AudioSource;
    [SerializeField] private AudioClip soundCharge;

    void Start()
    {
        startPos = transform.position.y;
        StartScaleSpring = spring.GetScale();
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.clip = soundCharge;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if(!gameManager.GetIsSceneScore())

            if (transform.position.y > startPos - mintPos)
            {
                if(doOnceSound)
                {
                    doOnceSound = false;
                    PlayAudio();
                }
                
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
                force += addForce * Time.deltaTime;
                doOnce = true;
                spring.AjusteScale(-scaleSpring );
            }

        }
        else
        {
            if (doOnce && ball != null)
            {
                doOnceSound = true;
                StopAudio();
                doOnce = false;
                ball.GetComponent<MovementManager>().StartSpring(force);
                force = 0;
            }
            if (transform.position.y < startPos)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + speedRevert * Time.deltaTime, transform.position.z);
                spring.AjusteScale(-scaleSpring * (speedRevert / speed));
                ball = null;
            }
            else
            {
                spring.SetScale(StartScaleSpring);
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ball = other.gameObject;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ball = other.gameObject;
        }
    }

    private void PlayAudio()
    {
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
    }

    private void StopAudio()
    {
        m_AudioSource.Stop();
    }
}


