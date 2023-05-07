using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.Camera;

namespace LesserKnown.Camera {
    public class CameraBoss : CameraFollow
    {
        public GameObject camNiveau;
        public CharacterController player1;
        public float _smoothing;
        // Start is called before the first frame update
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {
            _smoothing = 5.78f * Time.deltaTime;
        }

        public void TransitionBetweenCams() 
        {
            Vector3 target = transform.position;
            transform.position = Vector3.Lerp(camNiveau.transform.position, target, _smoothing);
            camNiveau.SetActive(false);
            //Set_Camera_Boss(); //suit le player mais pas meme offset
        }
    }
}
