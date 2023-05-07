using System.Collections;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    [SerializeField]
    protected Animator anim;
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject smokeDead;
    [SerializeField]
    GameObject powerUp;
    [SerializeField]
    GameObject heartPrefab;
    [SerializeField]
    protected GameObject noseShip;
    [SerializeField]
    AudioSource soundDead;
    [SerializeField]
    protected SpriteRenderer sprite;
    [SerializeField]
    protected GameObject[] smoke;
    public GameObject canon1;
    public GameObject canon2;
    public GameManagerBulletHell gameManager;
    public int smokeIdx = -1;
    public int delayRed = 10;
    public int delayhit = 1;
    public float life = 100;
    public float flashingRate = 0.15f;
    public float damage = 20;
    public Vector3 vecDir = new Vector3(0, 1, 0);
    public float speed;
    public float speedHit;
    public float speedRate;
    public float SpeedRotation;
    public float minRangeSpeed = 2.5f;
    public float maxRangeSpeed = 5.5f;
    public float rz;
    public float rot = 3.15f;
    protected bool canTakeDamage = true;
    protected bool doonce = true;
    protected bool isDead = false;
    public enum StateShip { Move, Hit, Fall, Aim };
    protected StateShip stateShip;

    // Start is called before the first frame update
     public virtual void Start()
    {
        speed = Random.Range(minRangeSpeed, maxRangeSpeed);
        stateShip = StateShip.Move;
        rz = (Random.Range(-108f, -109.1f));
        canon1.transform.rotation = Quaternion.EulerAngles(0, 0, rz);
        canon2.transform.rotation = Quaternion.EulerAngles(0, rot, rz);
    }

    // Update is called once per frame
   virtual public void Update()
    {
        switch (stateShip)
        {
            case StateShip.Move:
                vecDir = noseShip.transform.position - transform.position;
                transform.position += vecDir * speed * Time.deltaTime;
                canon2.transform.rotation = Quaternion.EulerAngles(0, rot, rz);
                break;
            case StateShip.Hit:
                break;
            case StateShip.Fall:
                if(transform.position.y < -4 )
                {
                    if(doonce)
                    {
                        doonce = false;
                        DestroyShip();
                    }
                }
                transform.Rotate(0, 0, rot *2, Space.Self);
                vecDir = noseShip.transform.position - transform.position;
                transform.position += Vector3.down * speed * Time.deltaTime;
                canon2.transform.rotation = Quaternion.EulerAngles(0, rot, rz);
                break;
        }
    }

    IEnumerator RotateCanon()
    {
        canon1.transform.rotation = Quaternion.EulerAngles(0, 0, rz);
        canon2.transform.rotation = Quaternion.EulerAngles(0, rot, rz);
        yield return new WaitForSeconds(SpeedRotation);
    }

    virtual public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Bullet"))
        {
            if(collision.CompareTag("Bullet") && !isDead)
            {
                Destroy(collision.gameObject);
            }
            if (canTakeDamage)
            {
                if (smokeIdx > 6)
                {
                    DestroyShip();
                }
                else
                {
                    smoke[smokeIdx].SetActive(true);
                    smokeIdx++;
                }
                canTakeDamage = false;
                if (collision.CompareTag("Bullet"))
                {
                    Destroy(collision.gameObject);
                    if (life < 0)
                    {
                        if (Random.value < .8)
                        {
                            DestroyShip();
                        }
                        else
                        {
                            stateShip = StateShip.Fall;
                            StartCoroutine(FlashingRed());
                        }
                         
                    }
                    else
                    {
                        stateShip = StateShip.Hit;
                        anim.SetTrigger("Hit");
                        StartCoroutine(FlashingRed());
                        StartCoroutine(HitTrans());
                        life -= damage;
                    }
                }
                else
                {
                    DestroyShip();
                }
            }
        }
    }

    virtual public IEnumerator FlashingRed()
    {
        for (int i = 0; i < delayRed; i++)
        {

            sprite.color = Color.green;
            yield return new WaitForSeconds(flashingRate);
            sprite.color = Color.white;
            yield return new WaitForSeconds(flashingRate);
        }
        canTakeDamage = true;
    }

    protected IEnumerator HitTrans()
    {
        for (int i = 0; i < delayhit; i++)
        {
            transform.position += Vector3.up * speedHit * Time.deltaTime; ;
            yield return new WaitForSeconds(speedRate);
        }
        for (int i = 0; i < delayhit * 2; i++)
        {
            yield return new WaitForSeconds(speedRate);
        }
        stateShip = StateShip.Move;
    }

    protected void DestroyShip()
    {
        if(!isDead)
        {
            for (int i = 0; i < smokeIdx; i++)
            {
                smoke[i].SetActive(false);
            }
            isDead = true;
            canon1.SetActive(false);
            canon2.SetActive(false);
            sprite.enabled = false;
            soundDead.pitch = UnityEngine.Random.Range(2.5f, 3.0f);
            soundDead.Play();
            Instantiate(prefabExplosion, transform.position, Quaternion.identity);
            Instantiate(smokeDead, transform.position, Quaternion.identity);
            Destroy(this.gameObject, 1);
            tag = "Untagged";
            gameManager.SetScoreTxt(10);
            if (Random.value < .4)
            {
                if (Random.value < .7)
                {
                    Instantiate(powerUp, transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(heartPrefab, transform.position, Quaternion.identity);
                }
                    
            }
        }
    }
}
