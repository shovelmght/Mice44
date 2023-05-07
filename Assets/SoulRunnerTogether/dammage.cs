using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.Player;



public class dammage : MonoBehaviour
{
    public CharacterController2D player1;
    // Start is called before the first frame update

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            GetComponent<Collider2D>().enabled = false;
            other.GetComponent<CharacterController2D>().Get_Hit(1);
        }       
    }
}
