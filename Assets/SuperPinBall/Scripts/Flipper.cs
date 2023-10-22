using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Flipper : MonoBehaviour
{
    public PinBallGameManager gameManager;
    private float force = 20;
    private float forceController = 50;
    public bool isRight;
    private Rigidbody rb;
    private NewActionInputManager playerInput;
    private bool _LeftTriggerUp;
    private bool _RightTriggerUp;
    private void Awake()
    {
        playerInput = new NewActionInputManager();
    }

    public void OnEnable()
    {
        playerInput.Enable();
    }
    public void OnDisable()
    {
        playerInput.Disable();
    }
    
    void Start()
    {
        gameManager = PinBallGameManager.FindObjectOfType<PinBallGameManager>();
        rb = GetComponent<Rigidbody>();
        playerInput.ArcadeMain1.LB.performed += _ => SetLeftTriggerUp();
        playerInput.ArcadeMain1.RB.performed += _ => SetRightTriggerUp();
        playerInput.ArcadeMain1.LB.canceled += _ => SetLeftTriggerDown();
        playerInput.ArcadeMain1.RB.canceled += _ => SetRightTriggerDown();
    }

    private void SetLeftTriggerUp()
    {
        _LeftTriggerUp = true;
    }

    private void SetRightTriggerUp()
    {
        _RightTriggerUp = true;
    }
    
    private void SetLeftTriggerDown()
    {
        _LeftTriggerUp = false;
    }

    private void SetRightTriggerDown()
    {
        _RightTriggerUp = false;
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
        
        if (_LeftTriggerUp && !isRight && !gameManager.GetisMenuScene())
        {
            //_LeftTriggerUp = false;
            rb.velocity += Vector3.up * forceController;
        }

        if ( _RightTriggerUp && isRight && !gameManager.GetisMenuScene())
        {
            //_RightTriggerUp = false;
            rb.velocity += Vector3.up * forceController;
        }
        
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
