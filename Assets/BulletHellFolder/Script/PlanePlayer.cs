using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlanePlayer : MonoBehaviour
{
    [SerializeField]
    private Animator animCanvas;
    [SerializeField]
    private GameObject canvaOption;
    [SerializeField]
    protected GameObject[] smoke;
    [SerializeField]
    protected GameObject prefabSmoke;
    [SerializeField]
    protected GameObject prefabSmoke2;
    [SerializeField]
    protected GameObject prefabHit;
    [SerializeField]
    protected Shield shield;
    [SerializeField]
    protected SpriteRenderer sprite;
    [SerializeField]
    private SpriteRenderer spritePowerUp1;
    [SerializeField]
    private SpriteRenderer spriteNormal;
    [SerializeField]
    private GameObject particleBuster;
    [SerializeField]
    protected GameObject bullet;
    [SerializeField]
    private GameObject bulletPowerUp;
    [SerializeField]
    private GameObject bulletPowerUp2;
    [SerializeField]
    public GameManagerBulletHell gameManager;
    [SerializeField]
    public Slider ui;
    [SerializeField]
    private SpawnParallax paralaxManager;
    public AudioSource soundFire;
    public AudioSource soundhit;
    public Transform bulletPosRight;
    public Transform bulletPosLeft;
    public float maxBorderX = 8.27f;
    public float maxBorderY = 4.34f;
    public float fireRate = 0.15f;
    public float minScalePrefabHitSmoke = 0.1f;
    public float maxScalePrefabHitSmoke = 0.4f;
    public float flashingRate = 0.15f;
    public int delayInvincible = 2;
    public int life = 7;
    public int nbSideBullet = 3;
    public bool canGetDammage = true;
    public Rigidbody2D rb;
    public float delayStopTime;
    protected NewActionInputManager playerInput;
    protected float valueUiWanted;
    protected bool canAffectLife = true;
    protected bool doOnceDead = true;
    protected float revovedUISlider = 0.1375f;
    private float StartRevovedUISlider;
    private float speedX;
    private float speedY;
    private float lowSpeedBorder = 0.2f;
    public float normalSpeedBorder;
    private bool fire;
    private bool fireSpecial;
    

    private enum Power { Normal , PowerUp1, PowerUp2}
     Power power;


    private void Awake()
    {
        power = Power.Normal;
        Cursor.lockState = CursorLockMode.Locked;
        playerInput = new NewActionInputManager();
    }

    public void OnEnable()
    {
        playerInput.Enable();
    }
    public void OnDisable()
    {
        playerInput.Disable();
    }
    virtual public void Start()
    {
        playerInput.ArcadeMain.Option.performed += _ => OptionCanva();
        StartRevovedUISlider = revovedUISlider;
        playerInput.Disable();
        playerInput.ArcadeMain.Fire.performed += _ => Fire();
        playerInput.ArcadeMain.Fire.canceled += _ => Fire2();
    }

    private void OptionCanva()
    {
        playerInput.Disable();
        canvaOption.SetActive(true);
        animCanvas.ResetTrigger("Out");
        animCanvas.SetTrigger("In");
        Cursor.lockState = CursorLockMode.None;
        StartCoroutine(DelayStopTime());
        paralaxManager.ChangeColor();
    }

    virtual public IEnumerator DelayStopTime()
    {
        yield return new WaitForSeconds(delayStopTime);
        Time.timeScale = 0;
    }


    public void OptionCanvaOut()
    {
        playerInput.Enable();
        animCanvas.ResetTrigger("In");
        animCanvas.SetTrigger("Out");
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        paralaxManager.RestaureColor();
    }

    private void Fire()
    {
        fire = true;
        StartCoroutine(ShootFire());
    }

    private void Fire2()
    {
        fire = false;
    }

    // Update is called once per frame
    virtual public void Update()
    {
        float movementInput = playerInput.ArcadeMain.MoveX.ReadValue<float>();
        Vector3 currentPosition = transform.position;
        if (transform.position.x > -maxBorderX && transform.position.x < maxBorderX)
        {
            speedX = normalSpeedBorder;
        }
        else
        {
            speedX = lowSpeedBorder;
        }
        currentPosition.x += movementInput * speedX * Time.deltaTime;
        transform.position = currentPosition;

        movementInput = playerInput.ArcadeMain.MoveY.ReadValue<float>();
        currentPosition = transform.position;
        if (transform.position.y > -maxBorderY && transform.position.y < maxBorderY)
        {
            speedY = normalSpeedBorder;
        }
        else
        {
            speedY = lowSpeedBorder;
        }
        currentPosition.y += movementInput * speedY * Time.deltaTime;
        transform.position = currentPosition;

        if (fireSpecial)
        {
            Instantiate(bullet, new Vector3(bulletPosRight.position.x, bulletPosRight.position.y, 0), bulletPosRight.rotation);
            Instantiate(bullet, new Vector3(bulletPosLeft.position.x, bulletPosLeft.position.y, 0), bulletPosRight.rotation);
            soundFire.pitch = UnityEngine.Random.Range(2f, 3.0f);
            soundFire.Play();
        }
    }

    virtual public IEnumerator ShootFire()
    {
        if(canGetDammage)
        {
            switch (power)
            {
                case Power.Normal:
                    Instantiate(bullet, new Vector3(bulletPosRight.position.x, bulletPosRight.position.y, 0), bulletPosRight.rotation);
                    Instantiate(bullet, new Vector3(bulletPosLeft.position.x, bulletPosLeft.position.y, 0), bulletPosRight.rotation);
                    break;
                case Power.PowerUp1:
                    var bulletType2 = Instantiate(bulletPowerUp, new Vector3(bulletPosRight.position.x, bulletPosRight.position.y, 0), bulletPosRight.rotation);
                    bulletType2.gameObject.transform.rotation = Quaternion.identity;
                    bulletType2 = Instantiate(bulletPowerUp, new Vector3(bulletPosLeft.position.x, bulletPosLeft.position.y, 0), bulletPosRight.rotation);
                    bulletType2.gameObject.transform.rotation = Quaternion.identity;

                    break;
                case Power.PowerUp2:
                    var bulletType3 = Instantiate(bulletPowerUp, new Vector3(bulletPosRight.position.x, bulletPosRight.position.y, 0), bulletPosRight.rotation);
                    bulletType3.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    bulletType3 = Instantiate(bulletPowerUp, new Vector3(bulletPosLeft.position.x, bulletPosLeft.position.y, 0), bulletPosRight.rotation);
                    bulletType3.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    for (int i = 0; i < nbSideBullet; i++)
                    {
                        var bulletLeft = Instantiate(bulletPowerUp2, new Vector3(bulletPosRight.position.x, bulletPosRight.position.y, 0), bulletPosRight.rotation);
                        bulletLeft.gameObject.transform.rotation = Quaternion.identity;
                        bulletLeft = Instantiate(bulletPowerUp2, new Vector3(bulletPosLeft.position.x, bulletPosLeft.position.y, 0), bulletPosRight.rotation);
                        bulletLeft.GetComponent<BulletSide>().SetBulletIsRight();
                        bulletLeft.gameObject.transform.rotation = Quaternion.identity;
                    }
                    break;
                default:
                    break;
            }

            soundFire.pitch = UnityEngine.Random.Range(2f, 3.0f);
            soundFire.Play(); 
        }

        yield return new WaitForSeconds(fireRate);

        if (fire)
        {
            StartCoroutine(ShootFire());
        }
    }
    
    virtual public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BulletEnn"))
        {
                if (collision.gameObject.GetComponent<BulletEnnemy>() != null)
                {
                    Destroy(collision.gameObject);
                }
                var explo = Instantiate(prefabSmoke, collision.gameObject.transform.position, Quaternion.identity);
                float scaleHitSmoke = UnityEngine.Random.Range(minScalePrefabHitSmoke, maxScalePrefabHitSmoke);
                explo.transform.localScale = new Vector3(scaleHitSmoke, scaleHitSmoke, scaleHitSmoke);

                if (canGetDammage)
                {
                    TakeDammge(1);
                }  
        }
    }

    virtual public void TakeDammge(int dam)
    {

        valueUiWanted =  ui.value - revovedUISlider;
        if(life == 7)
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
            if (doOnceDead)
            {
                doOnceDead = false;
                ui.value = 0;
                Destroy(this.gameObject);
                prefabHit.SetActive(true);
                Instantiate(prefabSmoke, transform.position, Quaternion.identity);
                Instantiate(prefabSmoke2, transform.position, Quaternion.identity);
                gameManager.GameOver(false);
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
            SetEnumPower(false);
        }
    }

    virtual public IEnumerator Flashing()
    {
        for (int i = 0; i < delayInvincible; i++)
        {
            if(i > delayInvincible / 2)
            {
                prefabHit.SetActive(false);
                sprite.color = Color.white;
                canGetDammage = true;
            }
            sprite.enabled = false;
            yield return new WaitForSeconds(flashingRate);
            sprite.enabled = true;
            yield return new WaitForSeconds(flashingRate);
        }
    }
    
    public void SetEnumPower(bool add)
    {
        if(add)
        {
            if (power == Power.PowerUp1)
            {
                power++;
            }
            else if (power == Power.Normal)
            {
                power++;
            }
        }
        else if (power > 0)
        {
            power--;
        }
        SetPowerUp();
    }

    virtual public void SetPowerUp()
    {
        switch (power)
        {
            case Power.Normal:
          
                particleBuster.SetActive(false);
                GetComponent<SpriteRenderer>().sprite = spriteNormal.sprite;

                break;
            case Power.PowerUp1:
                GetComponent<SpriteRenderer>().sprite = spritePowerUp1.sprite;
                particleBuster.SetActive(true);
                break;
            case Power.PowerUp2:
                break;
            default:
                break;
        }
    }

    public void RestoreLife()
    {
        smoke[life].SetActive(false);
        life += 1;
        if(life == 7)
        {
            revovedUISlider = StartRevovedUISlider;
        }
        valueUiWanted = ui.value + revovedUISlider;
        if(canAffectLife)
        {
            StartCoroutine(SetUILife(true));
        }
    }
    protected IEnumerator SetUILife(bool add)
    {
        canAffectLife = false;
        yield return new WaitForSeconds(0.005f);

        if (add)
        {
            if (ui.value < valueUiWanted)
            {
                ui.value += 0.01f;
                StartCoroutine(SetUILife(true));
            }
            else
            {
                canAffectLife = true;
            }
        }
        else
        {
            if (valueUiWanted < ui.value)
            {
                ui.value -= 0.01f;
                StartCoroutine(SetUILife(false));
            }
            else
            {
                canAffectLife = true;
            }
        }
    }

    IEnumerator StopTime()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }
}
