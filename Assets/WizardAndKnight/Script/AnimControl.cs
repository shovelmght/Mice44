using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{

    [SerializeField]
    private float delay_Jump = 0.7f;     // Time delay for Jump
    private float currentDelayJump = 0;  // delay for Jump
    private bool doOnceJump;             // make set trigger Jump do once

    [SerializeField]
    private float delayAttack = 0.8f;     // Time delay for Jump
    private float currentDelayAttack = 0;  // delay for Jump
    private bool doOnceAttack ;             // make set trigger Jump do once

    [SerializeField]
    private float delayHit = 0.8f;     // Time delay for Jump
    private float currentDelayHit = 0;  // delay for Jump
    private bool doOnceHit;             // make set trigger Jump do once

    private bool doOnceDie;             // make set trigger die do once

    private PlayerController player;           // ref to player
    private InputManagerWizardAndKnight input = new InputManagerWizardAndKnight();   // ref to input control
    private Animator animator;                  // ref to animator controller


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<PlayerController>();   // get Reference to player
        animator = GetComponent<Animator>();                       // get his animator component
  
        if (GameManagerWizardAndKnight.instance.GetterIsArrowInputManager()) // Chek if player is knight
        {
            input = new InputManagerArrow();  // Change Input ASDW to arrow input
        }

    }


    // Update is called once per frame
    void Update()
    {

        //Anim Jump
        if (input.Jump())
        {
         
            if (!doOnceJump)    // make set trigger jump do once
            {
                animator.SetTrigger("Jump");
                doOnceJump = true;   // reset doOnce with delay

            }
        }
        //Anim die
        else if (player.GetDie())
        {
            if (!doOnceDie)      // make set trigger die do once
            {
                animator.SetTrigger("Die");
                doOnceDie = true;      // reset doOnce with delay
              
            }
   
        }
        //Anim Hit
        else if (player.GetHit())
        {
            if (!doOnceHit)            // make set trigger die do once
            {
                doOnceHit = true;   // reset doOnce with delay
                animator.SetBool("Hit", true);
                animator.SetBool("Idle", false);
                animator.SetBool("Run", false);

            }

        }
        //Anim Attack
        else if (input.ShootProjectil())
        {
            if(!doOnceAttack)
            {
                animator.SetTrigger("Attack");
                doOnceAttack = true;
            }
         
        }
        //Anim Run
        else if (player.GetRun())
        {
            animator.SetBool("Run", true);
            animator.SetBool("Idle", false);
            animator.SetBool("Shifting", false);
        }
        //Anim Shifting
        else if (input.WantsMoveRight() || input.WantsMoveLeft())
        {
            animator.SetBool("Shifting", true);
            animator.SetBool("Idle", false);
            animator.SetBool("Run", false);
            doOnceDie = false;
        }

        //Anim Idle
        else
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Shifting", false);
            animator.SetBool("Run", false);

        }


        //Delay for Jump
        if (doOnceJump)
        {
            if (currentDelayJump >= delay_Jump)
            {
                doOnceJump = false;          // reset doOnce with delay
                currentDelayJump = 0f;    // Rester Time

            }

            currentDelayJump += Time.deltaTime;  // Update time
        }

        //Delay for attack
        if (doOnceAttack)
        {
            if (currentDelayAttack >= delayAttack)
            {
                doOnceAttack = false;
                currentDelayAttack = 0f;    // Rester Time

            }

            currentDelayAttack += Time.deltaTime;  // Update time

        }

        //Delay for hit
        if (doOnceHit)
        {
            if (currentDelayHit >= delayHit)
            {
                doOnceHit = false;
                currentDelayHit = 0f;    // Rester Time

            }

            currentDelayHit += Time.deltaTime;  // Update time

        }
    }

 
}
