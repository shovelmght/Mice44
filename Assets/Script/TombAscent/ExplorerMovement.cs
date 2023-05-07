using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplorerMovement : MonoBehaviour
{
    public GameObject manager;

    public Rigidbody2D self;
    public Animator animator;

    public float moveSpeed = 10.0f;
    public float limit = 10.0f;
    public float climbSpeed = 2.0f;
    public float climbLimit = 2.0f;
    public float jumpHeight = 10.0f;
    public Vector2 spawnPosition;
    bool isTouchingLadder = false;
    bool isClimbing = false;
    bool isWalking = false;
    bool isJumping = false;
    public bool endState = false;
    bool isAirborne = false;
    bool goLeft = false;
    bool goUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goLeft)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        CheckInput();
        MoveSelf();
        ClimbSelf();
        Jump();
    }

    void CheckInput()
    {
        isWalking = false;
        isClimbing = false;

        if (Input.GetKey(KeyCode.A))
        {
            goLeft = true;
            isWalking = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            goLeft = false;
            isWalking = true;
        }

        if (Input.GetKey(KeyCode.W))
        {
            goUp = true;
            isClimbing = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            goUp = false;
            isClimbing = true;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }
    }

    void MoveSelf()
    {
        if (isWalking)
        {
            animator.SetBool("isWalking", true);
            if (goLeft)
            {
                self.velocity += new Vector2(-moveSpeed*Time.deltaTime, 0);
                if (self.velocity.x < -limit)
                {
                    self.velocity = new Vector2(-limit, self.velocity.y);
                }
            }
            else
            {
                self.velocity += new Vector2(moveSpeed * Time.deltaTime, 0);
                if (self.velocity.x > limit)
                {
                    self.velocity = new Vector2(limit, self.velocity.y);
                }
            }
        }
        else
        {
            animator.SetBool("isWalking", false);
            self.velocity = new Vector2(0, self.velocity.y);
        }
    }

    void ClimbSelf()
    {
        if (isTouchingLadder)
        {
            if (isClimbing)
            {
                if (goUp)
                {
                    self.velocity += new Vector2(0, climbSpeed * Time.deltaTime);
                    if (self.velocity.y > climbLimit)
                    {
                        self.velocity = new Vector2(self.velocity.x, climbLimit);
                    }
                }
                else
                {
                    self.velocity += new Vector2(0, -climbSpeed * Time.deltaTime);
                    if (self.velocity.y < -climbLimit)
                    {
                        self.velocity = new Vector2(self.velocity.x, -climbLimit);
                    }
                }
            }
            else
            {
                self.velocity = new Vector2(self.velocity.x, 0);
            }
            

            
        }
        
        
    }

    void Jump()
    {        

        if (isJumping && !isAirborne)
        {
            isAirborne = true;

            self.velocity += new Vector2(0, jumpHeight);
            animator.SetBool("isAirborne", true);
        }

        
        
    }

    

    public void RestartLevel()
    {
        animator.SetBool("isOver", false);
        endState = false;
        transform.position = spawnPosition;
        self.velocity = new Vector2(0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ladder")
        {
            isTouchingLadder = true;
            animator.SetBool("isClimbing", true);
            Debug.Log("Got Ladder");
            self.gravityScale = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ladder")
        {
            isTouchingLadder = false;
            animator.SetBool("isClimbing", false);
            self.gravityScale = 0.5f;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "PowerUp" && endState == false)
        {
            endState = true;
            animator.SetBool("isOver", true);

            manager.GetComponent<GameManager>().IncrementScore(3000);
            manager.GetComponent<GameManager>().TimeScore();
        }

        if (collision.collider.tag == "Enemy")
        {
            endState = true;
            animator.SetBool("isOver", true);
        }

        if (collision.collider.tag == "Floor")
        {
            RaycastHit2D checkGround = Physics2D.Raycast(transform.position, Vector2.down, 0.005f);

            if (checkGround.collider != null)
            {
                isAirborne = false;
                animator.SetBool("isAirborne", false);
            }


        }
    }

}
