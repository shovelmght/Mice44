using UnityEngine;

public class PillarType2 : MonoBehaviour
{
    private int addScore = 10;
    public int distBack = 100;
    public float SpeedTranslation = 0.01f;
    private float posZ = 0.5f;
    private bool lighIsOn = false;
    private float timer = 0;
    private float endTimer = 0.2f;
    public GameObject prefab;
    public GameObject prefab2;
    public PinBallGameManager gameManager;
    public GameObject lightSpot;
    private AudioSource m_AudioSource;
    [SerializeField] private AudioClip[] sound;

    private void Start()
    {
        posZ = transform.position.z;
        m_AudioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (transform.position.z > posZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - SpeedTranslation);
        }

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


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Ball"))
        {

            PlayAudio();
            lighIsOn = true;
            lightSpot.SetActive(true);
            other.GetComponent<MovementManager>().Rebond();
            GameObject prefab_1 = Instantiate(prefab, transform.position, Quaternion.identity);
            GameObject prefab_2 = Instantiate(prefab2, transform.position, Quaternion.identity);
            Destroy(prefab_1, 4);
            Destroy(prefab_2, 4);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + distBack);
            gameManager.Setscore(addScore);
        }
    }

    private void PlayAudio()
    {
        if (!gameManager.GetIsEndGame())
        {
            if (!gameManager.GetisChangingScene())
            {
                m_AudioSource.pitch = (Random.Range(0.5f, 1.5f));
                int n = Random.Range(1, sound.Length);
                m_AudioSource.clip = sound[n];
                m_AudioSource.PlayOneShot(m_AudioSource.clip);
                sound[n] = sound[0];
                sound[0] = m_AudioSource.clip;
            }
        }
    }
}
