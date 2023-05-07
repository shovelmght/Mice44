using UnityEngine;

public class PillardType1 : MonoBehaviour
{
    public GameObject prefab;
    public PinBallGameManager gameManager;
    public GameObject lightSpot;
    private int addScore = 5;
    private float timer = 0;
    private float endTimer = 0.2f;
    private bool lighIsOn = false;
    private AudioSource m_AudioSource;
    [SerializeField] private AudioClip[] sound;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (lighIsOn)
        {
            if (timer > endTimer)
            {
                lighIsOn = false;
                timer = 0;
                lightSpot.SetActive(false);
            }
            timer += Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            lighIsOn = true;
            lightSpot.SetActive(true);
            GameObject prefab_1 = Instantiate(prefab, transform.position, Quaternion.identity);
            Destroy(prefab_1, 4);
            gameManager.Setscore(addScore);
            PlayAudio();
        }
    }

    private void PlayAudio()
    {
        if(!gameManager.GetIsEndGame())
        {
            if(!gameManager.GetisChangingScene())
            {
                m_AudioSource.pitch = (Random.Range(0.75f, 1.25f));
                int n = Random.Range(1, sound.Length);
                m_AudioSource.clip = sound[n];
                m_AudioSource.PlayOneShot(m_AudioSource.clip);
                sound[n] = sound[0];
                sound[0] = m_AudioSource.clip;
            }
        }
    }
}
