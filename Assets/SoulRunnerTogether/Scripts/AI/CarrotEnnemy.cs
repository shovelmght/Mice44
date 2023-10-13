using System;
using System.Collections;
using System.Collections.Generic;
using LesserKnown.AI;
using LesserKnown.Player;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarrotEnnemy : MonoBehaviour, Enemy_Interface
{
    [SerializeField] private int _ScorePoints;
    [SerializeField] private TMP_Text _TextScore;
    [SerializeField] private SpriteRenderer _SpriteRenderer;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator _Animator;
    [SerializeField] private float _JumpForce = 10;
    [SerializeField] private float _MovementSpeed = 3;
    [SerializeField] private float _RandomScaleMAx = 0.5f;
    [SerializeField] private float _RandomScaleMIn = 4;
    [SerializeField] private float _RandomMovementMAx = 0.5f;
    [SerializeField] private float _RandomMovementMIn = 5;
    [SerializeField] private float _RandomJumpForceMAx = 7f;
    [SerializeField] private float _RandomJumpForceMIn = 15;
    [SerializeField] private ScoreManager _ScoreManager;
    [SerializeField] private Collider2D _Collider2D;
    private bool _DoOnce;
    private bool _IsDead;

    private bool _IsRight;
    private static readonly int Death1 = Animator.StringToHash("Death");
    private static readonly int Idle = Animator.StringToHash("Idle");
    private static readonly int Move = Animator.StringToHash("Move");


    private void Start()
    {
        int chanceToJump = Random.Range(1, 3);
        if (chanceToJump > 1)
        {
            _Animator.SetTrigger(Idle);
        }
        else
        {
            _Animator.SetTrigger(Move);
        }
        _JumpForce = Random.Range(_RandomJumpForceMAx, _RandomJumpForceMIn);
        float randomScale = Random.Range(_RandomScaleMAx, _RandomScaleMIn);
        transform.localScale = new Vector3(randomScale, randomScale, 1);
        _MovementSpeed = Random.Range(_RandomMovementMAx, _RandomMovementMIn);
    }

    void Update()
    {
        rb.velocity = new Vector2(_MovementSpeed, rb.velocity.y);
    }

    public void Jump()
    {
        rb.velocity = new Vector2(_MovementSpeed, _JumpForce);
        Debug.Log("Jump");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Border"))
        {
            if (!_DoOnce)
            {
                
                _DoOnce = true;
                _SpriteRenderer.flipX = !_SpriteRenderer.flipX;
                _MovementSpeed = -_MovementSpeed;
                Invoke(nameof(ResetDoOnce), 1);
            }
        
        }
        else if(col.CompareTag("Player"))
        {
            if(_IsDead){return;}
            col.GetComponent<CharacterController2D>().Dead();
        }
    }

    private void ResetDoOnce()
    {
        _DoOnce = false;
    }

    public void Get_Hit(int amount)
    {
        Death();
    }

    public void Death()
    {
        if(_IsDead){return;}

        rb.gravityScale = 0;
        _Collider2D.enabled = false;
        Transform parent = transform.parent;
        StartCoroutine(CameraShaker.Instance.Shake());
        StartCoroutine(FlashWhiteScreenManager._Instance.Flash());
        Debug.Log("StartCoroutine(CameraShaker.Instance.Shake());  " + parent.name + "  " + parent.position);
        _IsDead = true;
        _MovementSpeed = 0;
        _Animator.SetTrigger(Death1);
        _TextScore.text = _ScorePoints.ToString();
    }

    //Called by Animator/Animation
    public void Destroy()
    {
        Destroy(this.gameObject);
    }
    
    //Caled by animator/animation
    public void RaiseScore()
    {
        _ScoreManager.OnUpdateScore.Invoke(_ScorePoints);
    }
}
