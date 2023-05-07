using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlappyBirdFly : MonoBehaviour
{
    public float FlyForce = 1f;
    [SerializeField] GameManagerFlappyBird gameManager;
    Rigidbody2D _rigidbody;
    Animator animator;
    NewActionInputManager controls;
    AudioSource audioSource;

    private void Awake()
    {
        controls = new NewActionInputManager();
        controls.FlappyBird.Fly.performed += context => Fly();
    }

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        controls.FlappyBird.Enable();
    }
    private void OnDisable()
    {
        controls.FlappyBird.Disable();
    }

    private void Fly_performed(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    void Fly()
    {
        if (gameManager.IsPlaying())
        {
            _rigidbody.velocity = Vector2.up * FlyForce;
            animator.SetTrigger("Fly");
            audioSource.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (PlayerPrefs.GetInt("FBscore") > PlayerPrefs.GetInt("FBhighscore"))
            {
                gameManager.NewHighscore();
            }
            gameManager.GameOverFB();

        }
    }
}
