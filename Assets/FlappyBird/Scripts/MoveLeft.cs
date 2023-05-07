using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] float Speed;
    void Start()
    {

    }

    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }

    public float GetSpeed()
    {
        return Speed;
    }

    public void SetSpeed(float newSpeed)
    {
        Speed = newSpeed;
    }
}
