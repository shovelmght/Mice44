using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAnimContol : MonoBehaviour
{
    [SerializeField]
    private float endDelay = 6;       // delay for attack
    private float currentDelayAttack = 0;    // delay for attack
    private bool doOnce;         // make set trigger attack do once

    private Animator animator;       // ref to animator of enemy
    private GrockLork Grock;   // ref to ennemey



    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        Grock = gameObject.GetComponent<GrockLork>();

    }   


    // Update is called once per frame
    void Update()
    {
        // Attack animation
        if (Grock.GetAttack())
        {
            if (!doOnce)
            {

                animator.SetTrigger("Attack");
                doOnce = true;           // set do once true for not enter in this "if"

            }
                 
            // timer for while end of attack
            if (currentDelayAttack > endDelay)
            {

                Grock.SetAttack(false);
                doOnce = false;
                currentDelayAttack = 0;

            }

            currentDelayAttack += 1;
        }

        // dead animation
        if (Grock.GetDead())
        {
            animator.SetTrigger("Dead");
        }
    }
}

