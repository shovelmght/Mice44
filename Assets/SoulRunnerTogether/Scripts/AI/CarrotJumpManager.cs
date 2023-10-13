using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarrotJumpManager : MonoBehaviour
{
    [SerializeField] private CarrotEnnemy _CarrotEnnemy;
    [SerializeField] private int _ChanceToJump = 1;
    [SerializeField] private float _TimeBeforeCanJumpAgain = 5;
    private bool _CanJump = true;

    private void Update()
    {
        if (_CarrotEnnemy != null)
        {
            transform.position = _CarrotEnnemy.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            int chanceToJump = Random.Range(1, 3);
            if (chanceToJump > _ChanceToJump && _CanJump)
            {
                _CarrotEnnemy.Jump();
                _CanJump = false;
                Invoke(nameof(ReSetCanJump), _TimeBeforeCanJumpAgain);
            }
            
        }
    }

    private void ReSetCanJump()
    {
        _CanJump = true;
    }
}
