using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// make fire ball rotate around parent fire ball
public class CamRotation : MonoBehaviour
{
    [SerializeField]
    private float speed = 2;    // speed of roation
    private float rotation;     // rotation & speed

    // Update is called once per frame
    void Update()
    {
        rotation += speed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, rotation, 0); // Make Rotation of camera
    }
}
