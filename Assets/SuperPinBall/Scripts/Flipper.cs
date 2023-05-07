using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public PinBallGameManager gameManager;
    private float force = 20;
    public bool isRight;
    private Rigidbody rb;



    void Start()
    {
        gameManager = PinBallGameManager.FindObjectOfType<PinBallGameManager>();
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && !isRight && !gameManager.GetisMenuScene())
        {
            rb.velocity += Vector3.up * force;
        }

        if (Input.GetKey(KeyCode.D) && isRight && !gameManager.GetisMenuScene())
        {
            rb.velocity += Vector3.up * force;

        }
    }
    void Update()
    {

    }

    public void RightPaddle( bool right)
    {
       
        if (right && isRight)
        {
            rb.velocity += Vector3.up * force * 6;
        }

        if (!right)
        {
            rb.velocity += Vector3.up * force * 6;
        }
    
    }

}
