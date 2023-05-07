using UnityEngine;

public class MovementManager : MonoBehaviour
{
   
    public PinBallGameManager gameManager;
    public float speed = 2;
    public float jump = 10; 
    public float rebond = 1.5f;
    public float gravity = 1.5f;
    public float gravityhight = -50;
    public bool isMainBall;
    private bool isGravityUp = false;
    public Vector3 vec3;
    public int force2;
    public int forceSpring ;
    [SerializeField] private AudioClip[] sound;
    private Rigidbody rb;
    private AudioSource m_AudioSource;
    public CameraBall cameraBall;

    void Start()
    {
        cameraBall = CameraBall.FindObjectOfType<CameraBall>();
        gameManager = PinBallGameManager.FindObjectOfType<PinBallGameManager>();
        m_AudioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        rb.velocity = vec3 * force2;
        if (!isMainBall)
        {
            Destroy(this.gameObject, 45);
            if(!gameManager.isMenuScene)
            {
              cameraBall.AddBalls(this.transform);
            }
        }
    }

    private void FixedUpdate()
    {
        if (isGravityUp && rb.velocity.y > gravityhight)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y + gravity, rb.velocity.z);
        }
        else if (rb.velocity.y > gravityhight)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y - gravity, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            rb.velocity -= Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E))
        {
            rb.velocity += Vector3.right * speed * Time.deltaTime;
        }
    }

    void Update()
    {

    }
    public void Rebond()
    {
        rb.velocity = -rb.velocity * 0.5f;
    }

    public void StartSpring( float force)
    {
        rb.velocity = rb.velocity = new Vector3(0,1,0) * force;
    }

    public Vector3 GetVelocity()
    {
        return rb.velocity;
    }

    private void PlayAudio()
    {
        if (!gameManager.GetisChangingScene())
        {
            m_AudioSource.pitch = (Random.Range(1f, 3f));
            int n = Random.Range(1, sound.Length);
            m_AudioSource.clip = sound[n];
            m_AudioSource.PlayOneShot(m_AudioSource.clip);
            sound[n] = sound[0];
            sound[0] = m_AudioSource.clip;
        }

    }
    void OnCollisionEnter(Collision other)
    {
        PlayAudio();
    }

    public bool GetIsMainBall()
    {
        return isMainBall;
    }

    public void StopBall()
    {
        rb.isKinematic = true;
        if (gameManager.GetBallinGame() > 0)
        {
            if(!gameManager.GetisMenuScene())
            {
                cameraBall.SetMainBall();
            }
        }
        gameObject.SetActive(false);
    }

    public void SetMainBall(bool onOff)
    {
        isMainBall = true;
    }
}
