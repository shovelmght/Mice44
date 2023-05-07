using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.Public;



namespace LesserKnown.Player
{
    public class Bullet : MonoBehaviour
    {
        public float speed = 5f;
        //private CharacterController2D controller;
        private Rigidbody2D rb;
        private Vector2 screenBounds;
        // Start is called before the first frame update
        void Start()
        {
            //controller = GetComponent<CharacterController2D>();
            //if (controller.IsLookingLeft())
            //    speed = -5;
            rb = this.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(speed, 0);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }


}
