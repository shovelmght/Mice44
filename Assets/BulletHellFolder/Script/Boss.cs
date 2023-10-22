using System.Collections;
using UnityEngine;

public class Boss : PlanePlayer
{
    [SerializeField]
    private GameObject[] positionGo;
    [SerializeField]
    private GameObject lifeBar;
    [SerializeField]
    private GameObject noseCanonRight;
    [SerializeField]
    private GameObject noseCanonLeft;
    [SerializeField]
    private PlanePlayer player;
    [SerializeField]
    private AudioSource deadSound;
    [SerializeField]
    private MusicManager musicManager;
    public float minDelayFire = 0.4f;
    public float maxDelayFire = 1.4f;
    public float minDelayWait = 2.4f;
    public float maxDelayWait = 4.4f;
    public float speed = 1.4f;
    public float gapDist = 1f;
    public float delayBeginShoot = 3f;
    public float speedRotationShip = 0.5f;
    public float speedBulletPhase = 6;
    public float speedBulletFinalPhase = 6;
    private int idx = 7;
    private int nbFire = 3;
    private bool doOnce = true;
    private bool haveGoodRotation;
    private float lerpDuration = 0.6f;        //time of lerp
    private float valueToLerp = 1;              // is the value to lerp
    private float startValue = 0;         // is the normal transparence of UI
    private float endValue = 1.1f;           // is the end value of tranparance want lerp
    private Color _StartingColor;


    public override void Start()
    {
        _StartingColor = sprite.color;
        ui.value = 1;
        StartCoroutine(DelayToShoot());
        playerInput.Disable();
        lifeBar.SetActive(true);
        player.OnDisable();
        player.canGetDammage = false;
       StartCoroutine(musicManager.ChangeSong(true));
    }

    override public void Update()
    {
        if (positionGo[idx].transform.position.x + gapDist < transform.position.x)
        {
            transform.position += Vector3.left * speed *Time.deltaTime;
        }
        else if (positionGo[idx].transform.position.x - gapDist > transform.position.x)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }


        if (positionGo[idx].transform.position.y + gapDist < transform.position.y)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        else if (positionGo[idx].transform.position.y - gapDist > transform.position.y)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if(haveGoodRotation)
        {
            if (player != null)
            {
                Vector2 lookDir = new Vector2(player.transform.position.x, player.transform.position.y) - rb.position;
                float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
                rb.rotation = angle;

            }
        }
    }

    IEnumerator DelayToShoot()
    {
        yield return new WaitForSeconds(delayBeginShoot);
        player.OnEnable();
        player.canGetDammage = true;
        yield return new WaitForSeconds(delayBeginShoot);
        StartCoroutine(ShootFire());
        StartCoroutine(SwithPosition());
    }

    override public IEnumerator ShootFire()
    {
        if (doOnceDead)
        {
            float randFlt = Random.Range(minDelayFire, maxDelayFire);
            yield return new WaitForSeconds(randFlt);

            for (int i = 0; i < nbFire; i++)
            {
                var shell = Instantiate(bullet, new Vector3(bulletPosRight.position.x, bulletPosRight.position.y, 0), bulletPosRight.rotation);
                shell.GetComponent<Bullet>().shootDir = noseCanonRight.transform.position - transform.position;
                var shell2 = Instantiate(bullet, new Vector3(bulletPosLeft.position.x, bulletPosLeft.position.y, 0), bulletPosRight.rotation);
                shell2.GetComponent<Bullet>().shootDir = noseCanonLeft.transform.position - transform.position;
                if (haveGoodRotation)
                {
                    shell.GetComponent<Bullet>().speed = speedBulletFinalPhase;
                    shell2.GetComponent<Bullet>().speed = speedBulletFinalPhase;
                }
                else
                {
                    shell.GetComponent<Bullet>().speed = speedBulletPhase;
                    shell2.GetComponent<Bullet>().speed = speedBulletPhase;
                }

                soundFire.pitch = UnityEngine.Random.Range(2f, 3.0f);
                soundFire.Play();
                yield return new WaitForSeconds(fireRate);
            }

            if (life > 0)
                StartCoroutine(ShootFire());
        }

    }

    override public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Bullet"))
        {
            if (shield.GetLife() > 0)
            {
                shield.DamageShield();
                Destroy(collision.gameObject);
                var explo = Instantiate(prefabSmoke, collision.gameObject.transform.position, Quaternion.identity);
                float scaleHitSmoke = Random.Range(minScalePrefabHitSmoke, maxScalePrefabHitSmoke);
                explo.transform.localScale = new Vector3(scaleHitSmoke, scaleHitSmoke, scaleHitSmoke);
            }
            else
            {
                if(doOnce)
                {
                    doOnce = false;
                    Vector2 lookDir = new Vector2(player.transform.position.x, player.transform.position.y) - rb.position;
                    float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
                    startValue = rb.rotation;
                    endValue = angle + 360;
                    StartCoroutine(LerpRotation());
                }
                if (collision.gameObject.GetComponent<Bullet>() != null)
                {
                    Destroy(collision.gameObject);
                    var explo = Instantiate(prefabSmoke, collision.gameObject.transform.position, Quaternion.identity);
                    float scaleHitSmoke = Random.Range(minScalePrefabHitSmoke, maxScalePrefabHitSmoke);
                    explo.transform.localScale = new Vector3(scaleHitSmoke, scaleHitSmoke, scaleHitSmoke);
                }

                if (canGetDammage)
                {
                    TakeDammge(1);
                }
            }
        }
    }

    override public void TakeDammge(int dam)
    {

        valueUiWanted = ui.value - revovedUISlider;

        if (life == 7)
        {
            revovedUISlider -= 0.0175f;
        }
        if (canAffectLife)
        {
            StartCoroutine(SetUILife(false));
        }
        life -= dam;
        if (life < 0)
        {
            if(doOnceDead)
            {
                doOnceDead = false;
                for (int i = 0; i < smoke.Length; i++)
                {
                    smoke[i].SetActive(false);
                }
                prefabHit.SetActive(false);
                ui.value = 0;
                Destroy(this.gameObject, 1);
                deadSound.Play();
                sprite.enabled = false;
                prefabHit.SetActive(true);
                Instantiate(prefabSmoke, transform.position, Quaternion.identity);
                Instantiate(prefabSmoke2, transform.position, Quaternion.identity);
                gameManager.GameOver(true);
                lifeBar.SetActive(false);
            }
        }
        else
        {
            sprite.color = Color.red;
            canGetDammage = false;
            prefabHit.SetActive(true);
            soundhit.pitch = UnityEngine.Random.Range(0.75f, 1.25f);
            soundhit.Play();
            StartCoroutine(Flashing());
            smoke[life].SetActive(true);
        }
    }

    override public IEnumerator Flashing()
    {
        for (int i = 0; i < delayInvincible; i++)
        {
            if (i > delayInvincible / 2)
            {
                prefabHit.SetActive(false);
                sprite.color = _StartingColor;
               
            }
            sprite.enabled = false;
            yield return new WaitForSeconds(flashingRate);
            sprite.enabled = true;
            yield return new WaitForSeconds(flashingRate);
        }
        canGetDammage = true;
    }

    IEnumerator SwithPosition()
    {
        float randFlt = Random.Range(minDelayWait, maxDelayWait);
        yield return new WaitForSeconds(randFlt);
        idx  = Random.Range(0, positionGo.Length);
        StartCoroutine(SwithPosition());
    }




    override public void SetPowerUp()
    {
        life = 7;
    }

    public IEnumerator LerpRotation()
    {
        float timeElapsed = 0;             // set timeElapse to 0
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);   //lerp fonction
            timeElapsed += Time.deltaTime;   // The completion time in seconds since the last frame (Read Only).
            yield return null;     // wait for the next frame and continue execution from this line
            rb.rotation = valueToLerp;
        }
        haveGoodRotation = true;
    }

}
