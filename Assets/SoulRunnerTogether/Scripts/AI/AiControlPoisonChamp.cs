using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.Player;
using LesserKnown.Public;
using System.Linq;
using LesserKnown.Audio;

namespace LesserKnown.AI {
    public class AiControlPoisonChamp : MonoBehaviour, Enemy_Interface
    {
        public CharacterController2D[] players;
        private Animator anim;
        private float insidePoisonDistance = 5f;
        private float appear_distance = 8f;

        private AudioEnemySounds audioEnemyScrpt;

        private float spawn_delay = 4f;
        private float current_delay;
        public float current_distance;

        public List<float> distances_debug;

        public bool is_attacking;

        public GameObject fakePoisonCloud; 
        
        private void Start()
        {
            audioEnemyScrpt = GetComponent<AudioEnemySounds>();
            anim = GetComponent<Animator>();
            InvokeRepeating("Appear", 0, .1f);

            current_delay = spawn_delay;
            players = FindObjectsOfType<CharacterController2D>();
        }

        private void Update()
        {                
            if (current_delay >= spawn_delay)
            {
                if (is_attacking)
                {
                    PoisonBurst(false);
                    PoisonBurst(true);

                    foreach (var player in Verify_Distance(insidePoisonDistance))
                    {
                        if (PublicVariables.IS_FUSIONED)
                            player.Get_Hit(1);
                        else
                            player.Dead();
                    }
                }
                current_delay = 0f;
            }
            current_delay += Time.deltaTime;
            
        }

        public void Appear()
        {
            anim.SetBool("Appear", Verify_Distance(appear_distance).Count > 0);

            if (Verify_Distance(appear_distance).Count > 0)
                is_attacking = true;
            else
                is_attacking = false;
        }

        /// <summary>
        /// Activates the Mushroom Burst Periodic Poison Region
        /// </summary>
        public void PoisonBurst(bool poison_active) 
        {          
            fakePoisonCloud.SetActive(poison_active);
            if(poison_active)
                audioEnemyScrpt.PlayPoisonCloud();
                audioEnemyScrpt.PlayPoisonCloud();
        }

        public List<CharacterController2D> Verify_Distance(float distance_to_use)
        {
            List<CharacterController2D> _players = new List<CharacterController2D>();
            List<float> distances_d = new List<float>();

            foreach (var item in players)
            {
                Vector3 _direction = item.transform.position - transform.position;
                float _distance = _direction.magnitude;

                if (_distance <= distance_to_use)
                    _players.Add(item);
                current_distance = _distance;

                distances_d.Add(_distance);
            }
            distances_debug = distances_d; 
            return _players;
        }
        /// <summary>
        /// Activates the Mushroom Death animation
        /// </summary>
        public void Death()
        {
            if (PublicVariables.IS_FUSIONED)
                StartCoroutine(DelayDeath());
            else
            {
                anim.SetTrigger("Death");
                Destroy(gameObject, .5f);
            }

        }
        IEnumerator DelayDeath()
        {
            yield return new WaitForSeconds(0.5f);
            anim.SetTrigger("Death");
            Destroy(gameObject, .5f);
        }

        /// <summary>
        /// Activates the MushRoom Hurt animation
        /// </summary>
        public void Hurt()
        {
            anim.SetTrigger("Hurt");
        }

        public void Get_Hit(int amount)
        {
            Death();
        }

    }
}