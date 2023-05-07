using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrockLork : MonoBehaviour
{
    [SerializeField]
    private HUDScoreLife lifeBar;   //ref to life bar over his head
    [SerializeField]
    private GameObject trigger;     // ref to prefab trigger
    [SerializeField]
    private GameObject Particle;     // ref to prefab particle effect
    [SerializeField]
    private GameObject player;    // ref to player

    private SpriteRenderer spriteR;    // ref to player

    private float delayInvulnerabilityEnd = 0.275f;  // delay for change gravity   
    private float currentInvulnerability;    // current time of gravity changer

    private float distanceTrigger = 9.9f;     // distante between trigger   
    private float speed = 20;     // walk speend of ennemy
    private float currentScale = 0.6f;     // walk speend of ennemy
    private float speedChangeScale = 1.5f;     // walk speend of ennemy


    private int healt = 5;

    private bool hit;          // make call fonction spawn particle  do once
    private bool right;          // get orientation of object
    private bool attack;          
    private bool dead;
    private bool doOnce;    //enter in dead mode one time


    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1, 5);          // give a random speed walk of ennemy

        spriteR = GetComponent<SpriteRenderer>();
        Instantiate(trigger, transform.position + new Vector3(distanceTrigger,0,0), Quaternion.identity);      // intantiate trigger for zone of walk
        Instantiate(trigger, transform.position - new Vector3(distanceTrigger, 0, 0), Quaternion.identity);     // intantiate trigger for zone of walk


        if (GameManagerWizardAndKnight.instance.GetterIsKnight()) // check if player is knight
        {
            player = GameObject.Find("KnightHeroPlayer(Clone)");     // get transform of position spawn Wizard
        }
        else
        {
            player = GameObject.Find("WizardHeroPlayer(Clone)");     // get transform of position spawn Wizard

        }
    }



    // Update is called once per frame
    void Update()
    {
        //Shifting
        if (!right)
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        else
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }


        // Delay for reset speed and !invulnerability    
        // and do little animation hit
        if (hit)
        {
            if (currentInvulnerability > delayInvulnerabilityEnd)
            {
                if (GameManagerWizardAndKnight.instance.GetterHardDifficulty())  // check if the difficulty is set to hard
                    speed = 6;   //change speed shifting
                else
                    speed = 3;  //change speed shifting

                currentInvulnerability = 0;
                hit = false;
                spriteR.color = new Color(1, 1, 1);  //Restor color sprite
            }
            if (currentInvulnerability > delayInvulnerabilityEnd /2 )
            {
     
                    currentScale -= speedChangeScale * Time.deltaTime;   // set scale Y lower 
            }
               
            else
            {
               
                    currentScale += speedChangeScale * Time.deltaTime;   // set scale Y bigger
            }
            

            if (right)
            {
                if (healt > 0)
                    transform.localScale = new Vector3(0.6f, currentScale, 1);    //change scale
            }
            else
            {
                if (healt > 0)
                    transform.localScale = new Vector3(-0.6f, currentScale, 1);   //change scale
            }


            currentInvulnerability += Time.deltaTime;   // add time
        } 
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to trigger
        if (other.tag == "Trigger")
        {
            right = !right;       //change orientation
             transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);  // change side if sprite
        }
        //Check to see if the tag on the collider is equal to player
        if (other.tag == "Player")
        {
            attack = true;     // change bool for animator
            speed = 1;         // change the speed so as not to go through the enemy player

            // check if player is behind 
            if (IsBehing(player.transform.position) == false)
            {
                
                right = !right;     //change orientation
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);  // change side if sprite

            }
        }

        //Check to see if the tag on the collider is equal to projectol
        if (other.tag == "Projectile")
        {
            if(!hit)
            {
                if (GameManagerWizardAndKnight.instance.GetterHardDifficulty())  // check if the difficulty is set to hard
                    healt--;     // loose healt
                else
                    healt -= 2;   //loose more healt
                hit = true;          
                speed = 0;       //stop this ork
                lifeBar.SetLifeBar(healt);   //Set heat bar UI
                spriteR.color = new Color(1, 0, 0);   //change color sprite

                if (healt <= 0)
                {
                    if(!doOnce)
                    {
                        doOnce = true;
                        speed = 0;        //stop shifting 
                        dead = true;      // change bool for animator
                        StartCoroutine(InstantiateParticle());   // set dead animation
                        hit = true;
                        Destroy(this.gameObject, 0.5f);      // destroy object 
                        GameManagerWizardAndKnight.instance.SetScoreText(10);  //Set score text UI
                    }

                }

            }
        }
    }

    // set dead animation
    public IEnumerator InstantiateParticle()
    {

        for(int i = 0; i < 10; i++)
        {
       
            Instantiate(Particle, new Vector3(transform.position.x + Random.Range(-1f, 1f), transform.position.y + Random.Range(-1f, 1f), transform.position.z), Quaternion.identity);
            transform.localScale = new Vector3(transform.localScale.x - 0.05f, transform.localScale.y - 0.05f, 1);    // lerp scale to 0
            yield return new WaitForSeconds(0.05f);
       
        }   
    }

    //Getter bool attack
    public bool GetAttack()
    {
        return attack;
    }

    //Setter bool attack
    public void SetAttack(bool att)
    {
        attack = att;
    }

    //Getter bool Dead
    public bool GetDead()
    {
        return dead;
    }

    //Check if player is behind
    public bool IsBehing(Vector3 player)
    {

        bool behind;

        if (right)
        {
            Vector2 vecFront = Vector2.right;         // get is right vector
            Vector2 vecplayer = player - transform.position;        // get orientation
            if (vecFront.x * vecplayer.x + vecFront.y * vecplayer.y < 0)    //dot product
            {
                behind = true;       // if is below 0 the player is behind
            }
            else
                behind = false;
        }
        else
        {
            Vector2 vecFront = Vector2.left;        // get is left vector
            Vector2 vecplayer = player - transform.position;              // get orientation
            if (vecFront.x * vecplayer.x + vecFront.y * vecplayer.y < 0)        //dot product
            {
                behind = true;     // if is below 0 the player is behind
            }
            else
                behind = false;
        }

        return behind;
    }
}
