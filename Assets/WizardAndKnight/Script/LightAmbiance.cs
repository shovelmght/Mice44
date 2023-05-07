using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAmbiance : MonoBehaviour
{
    [SerializeField]
    private float degrees = 0.3f;

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += Vector3.up * degrees;   // rotate
    }
}
