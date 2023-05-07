using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// make fire ball rotate around parent fire ball
public class FireBallRotation : MonoBehaviour
{
    [SerializeField]
    private float speed = 2;    // speed of roation


    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += Vector3.forward * speed;  // make fire ball rotate 
    }
}
