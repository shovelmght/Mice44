using System;
using UnityEngine;
using System.Collections;
using LesserKnown.Player;
using LesserKnown.AI;

namespace LesserKnown.TrapsAndHelpers
{
    public class BoxControl : MonoBehaviour
    {
        public SpriteRenderer sprite;
        public SpriteRenderer spriteBoxPlayer;
        public CharacterController2D player; // -----------------------Must add solver to this object reference
        private Rigidbody2D rb;
        private Collider2D m_collider;
        private bool is_picked;
        public GameObject boxControl_2;
        public GameObject boxControl_1;
        private bool doOnce;
        public float rotat;
        private bool _CanKill = true;
        private void Start()
        {
            doOnce = true;
            rb = GetComponent<Rigidbody2D>();
            m_collider = GetComponent<Collider2D>();

        }
        public void Start_Animation(AnimManager player)
        {

            transform.SetParent(player.transform, true);
            StartCoroutine(Pick_BoxIE(player));
        }

        public void Throw()
        {
            StartCoroutine(ThrowIE());
     
        }

        private IEnumerator ThrowIE()
        {

            
            yield return new WaitForSeconds(.22f);
            rb.simulated = true;
            sprite.enabled = true;
            spriteBoxPlayer.enabled = false;
            transform.SetParent(null);
            rb.bodyType = RigidbodyType2D.Dynamic;
            m_collider.isTrigger = false;
            if (player.IsLookingLeft())                                 // ----------if character look left
                rb.AddForce(new Vector2(-8, 2.5f), ForceMode2D.Impulse); //--------- throw box left side
            if (!player.IsLookingLeft())                                //---------- if character look right
                rb.AddForce(new Vector2(8, 2.5f), ForceMode2D.Impulse); //-------------throw box right side
            is_picked = false;
            doOnce = true;
        }

        private void Update()
        {

            rotat = transform.rotation.z;
            if (rotat > 0.5f && rotat < 0.9f || rotat < -0.5f && rotat > -0.9f)
            {

                boxControl_2.SetActive(true);
                boxControl_1.SetActive(false);
            }
            else
            {
                boxControl_2.SetActive(false);
                boxControl_1.SetActive(true);
            }
           


            if (doOnce)
            {
                if (rb.velocity.magnitude <= .5f && !is_picked)
                {
                    rb.bodyType = RigidbodyType2D.Static;
                    m_collider.isTrigger = true;
                    doOnce = false;
                    rb.bodyType = RigidbodyType2D.Dynamic;
                    m_collider.isTrigger = false;

                }
            }

        }

        private IEnumerator Pick_BoxIE(AnimManager _player)
        {
            yield return new WaitForSeconds(1f);

            while (_player.Has_Stop_Animation())
            {
                transform.position += new Vector3(0, 5 * Time.deltaTime, 0);

                transform.position = Vector3.Lerp(transform.position, _player.controller.box_placer.position, .1f);   

                yield return null;
            }
            is_picked = true;
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.simulated = false;
            player.can_pick_up = true;
            sprite.enabled = false;
            spriteBoxPlayer.enabled = true;

        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                AiControlPoisonChamp enemy = other.GetComponent<AiControlPoisonChamp>();

                if (enemy != null)
                {
                    enemy.Death();
                }
            
       
                Debug.Log(rb.velocity);
                Debug.Log(rb.velocity.y);
                Debug.Log(rb.velocity.x);
                if (rb.velocity != Vector2.zero)
                {
                    CarrotEnnemy carrotEnemy = other.GetComponent<CarrotEnnemy>();
                    if (carrotEnemy != null)
                    {
                        carrotEnemy.Death();
                    }
                }
                else
                {
                    _CanKill = false;
                    Invoke(nameof(ResetDontKill),3);
                }
 
            }
        }

        private void ResetDontKill()
        {
            _CanKill = true;
        }

        public void ChangeLayer()
        {
            rb.bodyType = RigidbodyType2D.Static;
            m_collider.isTrigger = true;
        }
        public void ChangeLayerReverse()
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            m_collider.isTrigger = false;
        }

    }
}
