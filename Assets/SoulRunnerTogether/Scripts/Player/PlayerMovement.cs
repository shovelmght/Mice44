using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.Camera;
using LesserKnown.Public;

namespace LesserKnown.Player
{
    /// <summary>
    /// This function controlls all player actions
    /// I know it's named movement, but it does pretty everything
    /// </summary>
    public class PlayerMovement : MonoBehaviour
    {
        public float _ParalaxValue { get; private set; }
        [SerializeField] private Transform pfBullet;
        private CharacterController2D controller;

        [Header("Player Settings")]
        public float movement_speed = 10f;
        public float climbing_speed = 8f;
        public float jump_force = 30f;
        public float wall_jump_force = 8f;
        [Space(10)]
        [Header("Player Input Keys")]
        public KeyCode jump_key;
        public float jump_force_FUSION = 25f;
        public float jump_force_FALL = 10f;
        public Transform current_player;
        private bool doOnce;

        [SerializeField] private GameObject ParticleEffectPrefab;
        [SerializeField] private Transform ParticleEffectLeftContainer;
        [SerializeField] private Transform ParticleEffectRightContainer;
        private CameraFollow cam;

        private void Start()
        {
            doOnce = false;
            controller = GetComponent<CharacterController2D>();
            cam = UnityEngine.Camera.main.GetComponent<CameraFollow>();

        }

        private void Update()
        {
          
            if (!controller.is_active || controller.setIsMenuOn)

                return;

            if (Input.GetKeyDown(jump_key) || controller._IsJumping)
            {
                controller.Jump(jump_force);
                
            }
            //if (Input.GetKeyDown(jump_key))
            //{
            //    controller.Jump(jump_force);

            //}


            if (controller.wall_jump && !controller.is_fighter)
            {
                controller.Jump_Wall(new Vector2(wall_jump_force, jump_force));
            }
                

            if (Input.GetKeyDown(KeyCode.F)  && !controller.is_climbing_ladder|| controller._IsPunching && !controller.is_climbing_ladder)
            {
                StartCoroutine(controller.DontMove());
                controller._IsPunching = false;
                if (controller.is_fighter || PublicVariables.IS_FUSIONED)
                {
                    controller.Attack();
                    if (PublicVariables.IS_FUSIONED)
                    StartCoroutine(Spawn_projectil());


                }
                

                else if (!controller.is_fighter)
                    if (!PublicVariables.IS_FUSIONED)
                        controller.Pickup();
            }

            //if (PublicVariables.IS_FUSIONED) //peut sauter + haut!!
            //    jump_force = jump_force_FUSION;
        }
        //public void DontMove22()
        //{


        //    controller.vertical = 0; //--------------------------------------------tell if player can move
           

        //    controller.vertical = 0;

        //}

        private void FixedUpdate()
        {

            if (!controller.is_active || controller.setIsMenuOn)
                return;

            var h = Input.GetAxisRaw("Horizontal");
            _ParalaxValue = h;
            //var v = Input.GetAxisRaw("Vertical");

            if (controller.horizontalEnable)
            {

                controller.Move(h * movement_speed);

            }


                controller.Climb(controller.vertical * climbing_speed);


        }



        public void SpawnPunchParticleEffect()
        {
            if (controller.IsLookingLeft())
            {
                Instantiate(ParticleEffectPrefab, ParticleEffectLeftContainer.position, Quaternion.identity);
            }
            else
            {
                Instantiate(ParticleEffectPrefab, ParticleEffectRightContainer.position, Quaternion.identity);
            }
            
        }

        IEnumerator Spawn_projectil()
        {

            if (!doOnce)
            {
                doOnce = true;

                yield return new WaitForSeconds(0.3f);

                doOnce = false;

                if (controller.IsLookingLeft())
                {

                    Instantiate(pfBullet, transform.position + new Vector3(-3, 0, -542.1935f), transform.rotation * Quaternion.Euler(0f, 0f, 180f));

                }

                else
                    Instantiate(pfBullet, transform.position + new Vector3(4, -1, -542.1935f), Quaternion.identity);


            }

        }


    }
}
