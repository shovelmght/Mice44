using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAim : Ennemy
{
    public GameObject player;
    public float angle = 0;
    public float angle2 = 0;
    public float speedRotationShip = 0.5f;
    public float angularSpeed = 0.5f;
    public float minBeginDelay = 1.5f;
    public float maxBeginDelay = 4.5f;
    private float delay = 0;
    public float delayMax = 0;
    private bool dontMove;
    public Rigidbody2D rb;
   

    public override void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        speed = Random.Range(minRangeSpeed, maxRangeSpeed);
        stateShip = StateShip.Move;
        rz = (Random.Range(-108f, -109.1f));
        canon1.transform.rotation = Quaternion.EulerAngles(0, 0, rz);
        canon2.transform.rotation = Quaternion.EulerAngles(0, rot, rz);
        StartCoroutine(DelayToStopAndAim());
        Invoke(nameof(DestroyShip), 30);
    }

    public override void Update()
    {
        switch (stateShip)
        {
            case StateShip.Move:
                vecDir = noseShip.transform.position - transform.position;
                transform.position += vecDir * speed * Time.deltaTime;
                canon2.transform.rotation = Quaternion.EulerAngles(0, rot, rz);
                if (dontMove)
                {
                    delay += Time.deltaTime;
                    if (delay > delayMax)
                    {
                        delay = 0;
                        stateShip = StateShip.Aim;
                    }
                }
                break;
            case StateShip.Hit:
                break;
            case StateShip.Fall:
                if (transform.position.y < -4)
                {
                    if (doonce)
                    {
                        doonce = false;
                        DestroyShip();
                    }
                }
                transform.Rotate(0, 0, rot * 2, Space.Self);
                vecDir = noseShip.transform.position - transform.position;
                transform.position += Vector3.down * speed * Time.deltaTime;
                canon2.transform.rotation = Quaternion.EulerAngles(0, rot, rz);
                break;
            case StateShip.Aim:


                if(player != null)
                {
                    Vector2 lookDir = new Vector2(player.transform.position.x, player.transform.position.y) - rb.position;
                    angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
                    if (rb.rotation < angle + 180)
                    {
                        rb.rotation += speedRotationShip * Time.deltaTime;
                    }
                    else
                    {
                        rb.rotation -= speedRotationShip * Time.deltaTime;
                    }
                }
                break;      
        }
    }

    override public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("BulletEnn") && gameManager.bossIsHere || collision.CompareTag("Bullet"))
        {
            if (collision.CompareTag("Bullet") && !isDead || collision.CompareTag("Bullet") && !isDead)
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

    IEnumerator DelayToStopAndAim()
    {
        float randFlt = Random.Range(minBeginDelay, maxRangeSpeed);
        yield return new WaitForSeconds(randFlt);
        stateShip = StateShip.Aim;
        dontMove = true;
    }
}
