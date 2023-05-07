using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public PinBallGameManager gameManager;
    private bool doOnce = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if(!other.GetComponent<MovementManager>().isMainBall)
            {
                gameManager.SetballInGame(-1);
                if (other != null)
                    Destroy(other.gameObject);
            }
            else
            {

                  doOnce = false;
                  gameManager.SetballInGame(-1);
                if(other != null)
                  other.GetComponent<MovementManager>().StopBall();
               
            }
        }
    }
}
