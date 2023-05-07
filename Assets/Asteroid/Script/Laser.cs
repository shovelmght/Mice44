using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Floor" && collision.gameObject.tag != "Laser")
        {
            Destroy(this.gameObject);
        }
    }
}
