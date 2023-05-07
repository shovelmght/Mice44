using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.Player;

namespace LesserKnown.Camera
{
    /// <summary>
    /// This script makes the camera follow the player smoothly
    /// </summary>
    public class CameraFollow : MonoBehaviour
    {     
        public Transform target;
        [Range(1f,10f)]
        [Tooltip("Use this to smooth the movement of the camera")]
        public float camera_smoothing;

        [Range(5f, 10f)]
        [Tooltip("This is for the falling smoothing")]
        public float falling_camera_smoothing;

        [Header("For zoom in and out")]
        public float startingSize;
        public float zoomCamSize = 9f; //for boss ZoomOut
        public bool zoomToBoss;
        private UnityEngine.Camera thisCam;

        /// <summary>
        /// The offset of the camera
        /// </summary>
        private Vector3 offset;

        /// <summary>
        /// Used for testing when in multiplayer
        /// </summary>
        public bool testing;

        /// <summary>
        /// The current character that the camera is following
        /// Only used in multiplayer
        /// </summary>
        private CharacterController2D character;

        private void Start()
        {
            if (testing)
                Set_Camera(target, null);

            thisCam = GetComponent<UnityEngine.Camera>();
            startingSize = thisCam.orthographicSize;
        }

        /// <summary>
        /// Sets the camera in a multiplayer scene
        /// Do not use this if we're making single player
        /// </summary>
        /// <param name="target">The target it needs to follow</param>
        /// <param name="character">The CharacterController2d attatched to the target</param>
        public void Set_Camera(Transform target, CharacterController2D character)
        {
            this.target = target;
            this.character = character;
            offset = transform.position - target.position;
        }

        /// <summary>
        /// Sets the camera in single player
        /// Don't use this if we're making multiplayer
        /// </summary>
        /// <param name="target">The target it needs to follow</param>
        public void Set_Camera_Local(Transform target)
        {
            this.target = target;
            offset = new Vector3(0,0,-10);
        }

        /// <summary>
        /// For the Boss Fight View
        /// </summary>
        /// <param name="target">The target it needs to follow</param>
        public void Set_Camera_Boss(Transform target)
        {
            this.target = target;
            offset = new Vector3(0,0,-10);

            zoomToBoss = true;

        }



        void Update()
        {
            if(target == null)
            {
                Debug.LogError("Missing player to follow");
                return;
            }

            float _smoothing = camera_smoothing * Time.deltaTime;

            if(character != null)
            {
                if (!character.IsGrounded())
                    _smoothing = falling_camera_smoothing * Time.deltaTime;
            }

            if (!zoomToBoss)
                transform.position = Vector3.Lerp(transform.position, target.position + offset, _smoothing);

            else 
            {
                Vector3 endCamPosition = new Vector3(22, 130, -30); //hardcode pos CamBoss...*just for tests*

                thisCam.orthographicSize = Mathf.SmoothStep(startingSize, zoomCamSize, _smoothing);
                transform.position = Vector3.Lerp(transform.position, endCamPosition, _smoothing);

               // Debug.Log("transform.position et endCamPosition"+ transform.position+ endCamPosition);
                //if you arrived, do your follow as normal
               if (transform.position.Equals(endCamPosition))
                    zoomToBoss = false;
            }
        }
}
}
