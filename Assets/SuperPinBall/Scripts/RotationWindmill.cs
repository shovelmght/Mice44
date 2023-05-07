using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationWindmill : MonoBehaviour
{
    public float speedRotation = 4;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speedRotation * Time.deltaTime);
    }
}
