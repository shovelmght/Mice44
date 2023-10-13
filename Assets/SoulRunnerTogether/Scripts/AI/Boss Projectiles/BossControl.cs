using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.Player;
using LesserKnown.Public;
using LesserKnown.Audio;

namespace LesserKnown.AI
{
    public class BossControl : MonoBehaviour, Enemy_Interface
    {
        private bool is_invicible;
        public Transform current_player;
        private Animator anim;
        public GameObject lifeBar;
        public GameObject video;
        public GameObject endUIReturn;
        public GameObject endUIExit;
        public GameObject _PausePannel;
        public GameObject ui;
        public AudioSource audioSource;
        public float endTimer;
        public float speedLerp;
        private bool isDead;
        


        [Space(10)]
        [Header("Objects to Spawn")]
        public GameObject light_flash;
        public float fire_flash_delay = .5f;
        private float current_flash_delay = .5f;

        public float fire_flash_cd = 5f;
        private float fire_flash_current_cd;
        public float spell_duration = 3f;
        public float movement_cd = 1.5f;
        public float current_movement_cd;

        private SpriteRenderer sprite;
        public int delayInvincible;
        public float flashingRate;

        private void Start()
        {
            Cursor.lockState = CursorLockMode.None;
            isDead = false;
            current_flash_delay = fire_flash_delay;
            fire_flash_current_cd = fire_flash_cd;
            anim = GetComponent<Animator>();
            current_movement_cd = movement_cd;
            sprite = GetComponent<SpriteRenderer>();
        }

        public void Spawn_Boss(Transform player)
        {
            current_player = player;
        }

        private void Update()
        {
            if (current_player == null)
                return;

            Vector3 _dir = (transform.position - current_player.position).normalized;

            sprite.flipX = _dir.x < 0;


            if (fire_flash_current_cd >= fire_flash_cd)
            {
                StartCoroutine(Fire_IE());
                fire_flash_current_cd = 0f;

                AudioEnemySounds audioscript = GetComponent<AudioEnemySounds>();
                audioscript.PlayPoisonCloud();
            }
            fire_flash_current_cd += Time.deltaTime;

            if (!is_invicible)
            {
                if (current_movement_cd >= movement_cd)
                {
                    transform.position -= new Vector3(_dir.x / 2f, 0, 0);
                    anim.SetTrigger("Move");
                    current_movement_cd = 0f;
                    if (Player_Too_Close()) current_player.GetComponent<CharacterController2D>().Get_Hit(1);
                }
                current_movement_cd += Time.deltaTime;
            }          
        }

        private bool Player_Too_Close()
        {
            Vector3 _direction = transform.position - current_player.position;
            float _distance = _direction.magnitude;

            if (_distance <= 2f)
                return true;

            return false;
        }



        private IEnumerator Fire_IE()
        {
            float current_duration = 0f;
            anim.SetTrigger("Hide");
            is_invicible = true;
            current_movement_cd = 0f;
            while (current_duration < spell_duration)
            {

                if (current_flash_delay >= fire_flash_delay)
                {
                    if(!isDead)
                    {
                        current_flash_delay = 0f;
                        var _copy = Instantiate(light_flash, current_player.position - new Vector3(0, 0, 5), Quaternion.identity);
                    }
                }
                current_flash_delay += Time.deltaTime;

                current_duration += Time.deltaTime;
                yield return null;

            }
            anim.SetTrigger("Appear");
            is_invicible = false;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
                current_player = collision.transform;
        }

        public void Get_Hit(int amount)
        {
            if (is_invicible)
                return;

            if (PublicVariables.hp_boss > 0)
            {
                StartCoroutine(CameraShaker.Instance.Shake());
                StartCoroutine(FlashWhiteScreenManager._Instance.Flash());
                PublicVariables.hp_boss -= amount;
                anim.SetTrigger("Hit");
                StartCoroutine(DelayInvincible());
            }

            if(PublicVariables.hp_boss == 0) 
            {
                Death();
              
            }

            Vector3 _dir = (transform.position - current_player.position).normalized;
            transform.position += new Vector3(_dir.x/2f, 0, 0);
        }
        public void Death() 
        {
            isDead = true;
            anim.SetTrigger("Death");
            AudioEnemySounds audioscript = GetComponent<AudioEnemySounds>();
            audioscript.PlayDead();
            Destroy(gameObject, 30f);
            StartCoroutine(DelayDead());

        }

        IEnumerator DelayDead()
        {

            StartCoroutine(DelayDead2());
    
            yield return new WaitForSeconds(1.9f);

            video.SetActive(true);
            ui.SetActive(false);
        }

        IEnumerator DelayDead2()
        {
            StartCoroutine(FadeOut());
            Debug.Log("End-1");
            yield return new WaitForSeconds(0.5f);
            AudioEnemySounds audioscript = GetComponent<AudioEnemySounds>();
            audioscript.PlayDead2();
            gameObject.GetComponent<Renderer>().enabled = false;      // make invisible 
            Destroy(lifeBar.gameObject);      // destroy this game object
            yield return new WaitForSeconds(endTimer);
            Cursor.lockState = CursorLockMode.None;
            _PausePannel.SetActive(false);
            endUIReturn.SetActive(true);
            endUIExit.SetActive(true);
        }

        public IEnumerator FadeOut()
        {

            while (audioSource.volume > 0)
            {

                audioSource.volume -= speedLerp * Time.deltaTime;
                yield return null;
            }
        }
        public IEnumerator DelayInvincible()
        {
            is_invicible = true;

             yield return new WaitForSeconds(flashingRate);   
            is_invicible = false;
        }
    }
}
