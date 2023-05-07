using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarType3 : MonoBehaviour
{
    public LerpBiggerBall topBall;
    public MovementManager ball;
    public GameObject prefabBall;
    public GameObject prefab;
    public GameObject prefab2;
    public PinBallGameManager gameManager;
    public GameObject lightSpot;
    public Transform locBall;
    private int addScore = 15;
    private bool doOnceRotation = true;
    private bool doOnceBall = true;
    private bool rotateUp = false;
    private bool rotateDown = false;
    private bool gameOverEvent = false;
    private float speedRotation = 200;
    private float posZ = 22.08f;
    private float toppBallScale = 0.001f;
    private float timer = 0;
    private float endTimerRot = 0.5f;
    private float endTimer = 1.05f;
    private float endTimerLight = 1f;
    public Quaternion startQuaternion;
    private Vector3 ballVelo;
    private AudioSource m_AudioSource;
    [SerializeField] private AudioClip[] sound;

    private void Start()
    {
        startQuaternion = transform.rotation;
        m_AudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            event0();
        }

        if (rotateUp)
        {
            transform.Rotate(-ballVelo * speedRotation * Time.deltaTime);
        }

        if (rotateDown)
        {
            transform.Rotate(ballVelo * speedRotation * Time.deltaTime);
        }

        if(!doOnceRotation)
        {

            if (timer > endTimerLight)
            {
                lightSpot.SetActive(false);
            }

            if (timer > endTimerRot)
            {
                if (doOnceBall)
                {
                    doOnceBall = false;
                    Instantiate(prefabBall, new Vector3(locBall.transform.position.x, locBall.transform.position.y, posZ), Quaternion.identity);
                    gameManager.SetballInGame(1);
                    topBall.SetScale(toppBallScale);
                    rotateDown = true;
                    rotateUp = false;
                }
            }
                if (timer > endTimer)
                {
                doOnceBall = true;
                doOnceRotation = true;
                timer = 0;
                rotateDown = false;
                transform.rotation = startQuaternion;
                }
            timer += Time.deltaTime;
        }

        if(gameOverEvent)
        {
            Instantiate(prefabBall, new Vector3(locBall.transform.position.x, locBall.transform.position.y, 22.08f), Quaternion.identity);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

         if (other.gameObject.CompareTag("Ball"))
         {
            if (doOnceRotation)
            {
                if (!gameOverEvent)
                {
                    PlayAudio();
                    gameManager.Setscore(addScore);
                    lightSpot.SetActive(true);
                    doOnceRotation = false;
                    ballVelo = other.GetComponent<MovementManager>().GetVelocity().normalized;
                    GameObject prefab_1 = Instantiate(prefab, transform.position, Quaternion.identity);
                    GameObject prefab_2 = Instantiate(prefab2, transform.position, Quaternion.Euler(Vector3.up));
                    Destroy(prefab_1, 4);
                    Destroy(prefab_2, 4);
                    rotateUp = true;
                    other.GetComponent<MovementManager>().Rebond();
                }
            }
         }  
    }


    private void event0()
    {
        if (doOnceRotation)
        {
            if (!gameOverEvent)
            {
                PlayAudio();
                gameManager.Setscore(addScore);
                lightSpot.SetActive(true);
                doOnceRotation = false;

                GameObject prefab_1 = Instantiate(prefab, transform.position, Quaternion.identity);
                GameObject prefab_2 = Instantiate(prefab2, transform.position, Quaternion.Euler(Vector3.up));
                Destroy(prefab_1, 4);
                Destroy(prefab_2, 4);
                rotateUp = true;
            }
        }
    }

    public void SetGameOverEvent(bool onOff)
    {
        gameOverEvent = onOff;
    }

    private void PlayAudio()
    {
        m_AudioSource.pitch = (Random.Range(1.7f, 2.2f));
        int n = Random.Range(1, sound.Length);
        m_AudioSource.clip = sound[n];
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
        sound[n] = sound[0];
        sound[0] = m_AudioSource.clip;
    }
}
