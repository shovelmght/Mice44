using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.AI;





    public class Bullet2 : MonoBehaviour
    {
        public float speed = 8f;

        private Rigidbody2D rb;
        // Start is called before the first frame update
        void Start()
        {

            if(transform.rotation.z > 0)
            {
                speed = -8;

            }
        Destroy(gameObject, 1f);



        rb = this.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(speed, 0);
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Enemy")
            {
            AiControlPoisonChamp enemy = other.GetComponent<AiControlPoisonChamp>();
            enemy.Death();
       

       
            }
             else if (other.tag == "Boss")
             {
               BossControl enemy = other.GetComponent<BossControl>();
               enemy.Get_Hit(1);
               Destroy(gameObject);
              }
        }
    //IEnumerator Del_Dest()
    //{
    //    yield return new WaitForSeconds(1f);
    //    Destroy
    //}



        // Update is called once per frame
        void Update()
        {

        }
    }



