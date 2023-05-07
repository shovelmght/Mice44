using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ball;

    void Update()
    {
        transform.position = ball.transform.position;
    }
}
