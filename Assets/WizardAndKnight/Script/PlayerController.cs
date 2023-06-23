using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private LevelManager levelManager;       // ref to Level manager
    [SerializeField]
    private GameObject projectil;      // ref to prefab projectile Wizard
    [SerializeField]
    private float gravity = 4.5f;          //gravity when in the air
    [SerializeField]
    private float speedWalk = 4.8f;       // speed of walk
    [SerializeField]
    private float speedRun = 6f;          // speed of run
    [SerializeField]
    private float forceJump = 300;       // force of jump
    [SerializeField]
    private float normalGravity = 1.5f;
    
    [SerializeField]
    private float _CanJumpDelayTime = 0.5f; 


    [SerializeField]
    private float delayGravityEnd = .5f;  // delay for change gravity   
    private float currentDelayGravityChange;    // current time of gravity changer

    [SerializeField]
    private float delayInvulnerabilityEnd = .5f;  // delay for change gravity   
    private float currentInvulnerability;    // current time of gravity changer

    [SerializeField]
    private float delayRunEnd = 2f;  // delay for change gravity   
    private float currentDelayRun;   // current time of delay

    [SerializeField]
    private float delayProjectilEnd = 0.15f;  // delay for projectil stop shooting
    private float currentDelayPro;             // current time of projectil animation

    [SerializeField]
    private int Healt;         // Life of player

    private float speed = 4.8f;         //current speed


    private bool jump;                   // for delay gravity
    private bool canJump = true;        // check if he can jump
    private bool canShoot;               // check if he can shoot projectil
    private bool hit;               // check if he can shoot projectil

    private bool right = true;          // get look left of right
    private bool die;
    private bool doOnceDead;              // make set die do once
    private bool run;                   
    private bool inputEntercave;      // check if he can press button for enter cave B
    private bool canOpenChest;      // check if he can press button for open chest
    private bool rotate;            // for active movement rotate for action button
    private bool IsInvulnerable;
    
    
    private bool _JumpImput;
    private bool _FireImput;
    private bool _EnterCaveImput;
    private float MovementInput;
    public int _CurrentDeep;

    protected NewActionInputManager playerInput;
    private Transform transProjectil;    //position spawn projectil
    public Rigidbody2D rb;              // ref to Rigidbody2D
    public ChestOpener chestOpener;      // ref to chest



    private InputManagerWizardAndKnight input = new InputManagerWizardAndKnight();

    
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
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("_CurrentDeep =  " + _CurrentDeep);
        _CurrentDeep = 0;
        playerInput.WizardAndKnight.Action.performed  += _ => SetFireOn();
        playerInput.WizardAndKnight.Action.canceled  += _ => SetFireOff();
        playerInput.WizardAndKnight.Fire.performed  += _ => SetJumpOn();
        playerInput.WizardAndKnight.Fire.canceled  += _ => SetJumpOff();
     
        if (GameManagerWizardAndKnight.instance.GetterIsArrowInputManager())  // Chek if player is knight
        {
            input = new InputManagerArrow();   // Change Input ASDW to arrow input
        }


        levelManager = GameObject.FindObjectOfType<LevelManager>();   // Get ref Level Manager  
        chestOpener = GameObject.FindObjectOfType<ChestOpener>();    //get chest class


        rb = GetComponent<Rigidbody2D>();                    // get Rigidbody2D component
        transProjectil = transform.Find("TransProject");     // get transform of position spawn projectil

        Healt = 5;
    }

    // Update is called once per frame
    void Update()
    {

        bool fireInpute;
        bool jumpImput;
        
        MovementInput = playerInput.WizardAndKnight.MoveX.ReadValue<float>();
        
        _EnterCaveImput = playerInput.WizardAndKnight.MoveY.ReadValue<float>() > 0;

        jumpImput = _JumpImput;
        if (!jumpImput)
        {
            jumpImput = input.Jump();
        }

        fireInpute = _FireImput;
        if (!fireInpute)
        {
            fireInpute = input.ShootProjectil();
        }
        

        bool wantsMoveRight = input.WantsMoveRight();
        bool wantsMoveLeft = input.WantsMoveLeft();

        if (MovementInput > 0)
        {
            wantsMoveRight = true;
        }
        else if(MovementInput < 0)
        {
            wantsMoveLeft = true;
        }
        
        //  Move right / D
        if (wantsMoveRight && !canShoot && !die && _CanMove)           
        {
            if (right)
            {

                transform.localRotation = Quaternion.Euler(0, 180, 0);   // change side of player for he look right
                right = false;


            }
            //Check how long it moves in the same direction
            if (currentDelayRun >= delayRunEnd && canJump)
            {

                currentDelayRun = 0f;   // reset current time
                run = true;          // set bool for animator
                speed = speedRun;    // change speed to run speed

            }

            currentDelayRun += Time.deltaTime;    // add time to timer

            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;  //move player right
        }

       //  Move right / A
        else if (wantsMoveLeft && !canShoot && !die && _CanMove)            
        {
            if (!right )
            {

                transform.localRotation = Quaternion.Euler(0, 0, 0);   // change side of player for he look left
                right = true;

            }
            //Check how long it moves in the same direction
            if (currentDelayRun >= delayRunEnd && canJump)
            {

                currentDelayRun = 0f;  // reset current time delay
                run = true;         // set bool for animator
                speed = speedRun;    // change speed to run speed

            }

            currentDelayRun += Time.deltaTime;     // add time to timer

            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime; //move player left

        }

        //if he dont move
        else
        {
            run = false;                 // set bool for animator
            currentDelayRun = 0f;         // reset current time
            speed = speedWalk;          // set speed to speed walk
        }

        //restart game level
        if(input.Restart())
        {
            levelManager.SetRespawnBeginning(true);            // delay respawn player even(set world correctly)
        }

        //  Jump
        if (jumpImput && canJump && !canShoot && !die && currentDelayGravityChange == 0 && _CanJumpDelay && !inputEntercave && _CanMove)
        {
            _CanJumpDelay = false;
            Invoke(nameof(CanJumpDelay), _CanJumpDelayTime);
            rb.gravityScale = normalGravity;
            rb.AddForce(new Vector2(0, forceJump), ForceMode2D.Force);  // make jump
            jump = true;                // set bool jump for animator
            canJump = false;           // set bool can jump for not jump twice

        }

        // Delay for change gravity
        if (jump && !inputEntercave)
        {

            // Delay for change gravity
            if (currentDelayGravityChange >= delayGravityEnd)
            {
                jump = false;                   // set bool jump for animator
                currentDelayGravityChange = 0f;    // reset current time delay
                if (!canJump)                    // dont change gravity if he land floor
                    rb.gravityScale = gravity;

            }

            currentDelayGravityChange += Time.deltaTime;   // add time to timer
        }

        // shoot projectil
        if (fireInpute && !canShoot  && !die && !inputEntercave && _CanMove)
        {
            canShoot = true;    // active delay for animation attack 
        }

        // delay for animation attack
        if (canShoot && !inputEntercave)
        {
            // Instantiate projectil while animation attack
            if (currentDelayPro > delayProjectilEnd && currentDelayPro < delayProjectilEnd * 2)
            {

                if (GameManagerWizardAndKnight.instance.GetterIsKnight())   //check if character is knight
                {
                    Instantiate(projectil, transProjectil.transform.position, transProjectil.transform.rotation);     // Instantiate projectil
                }
       
                else
                    Instantiate(projectil, transProjectil.transform.position, transform.rotation);     // Instantiate projectil
            }


            if (currentDelayPro >= delayProjectilEnd * 3.6f)
            {

                canShoot = false;          // set bool can canShoot for not attack twice
                currentDelayPro = 0f;      // reset current time delay

            }

            currentDelayPro += Time.deltaTime;     // add time to timer
        }


        if (!_EnterCaveImput)
        {
            _EnterCaveImput = input.EnterCave();
        }
        if (_EnterCaveImput)
        {
        
            inputEntercave = true;
 
        }
          
        else
            inputEntercave = false;
        

        //check if player is in trigger chest and buttom enter is press
        if (canOpenChest && _EnterCaveImput && _CurrentDeep == chestOpener._Deep)
        {
            _CanMove = false;
            rotate = true;
            chestOpener.OpenChest();
            Destroy(gameObject,6);
        }
       
        //make rotation of player
        if (rotate)
        { 
            
            if (currentDelayGravityChange >= delayGravityEnd)  //delay
            {
                Invoke(nameof(SetDisableInputDelay), 2);
                currentDelayGravityChange = 0f;   //Reset currentDelayGravityChange for next time

            }

            rb.gravityScale = 0;                    // set gravity to 0, if not he fall
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.time * speed /400);   // Lerp rotation 90 degrees
            currentDelayGravityChange += Time.deltaTime;   // add time

        }

        if(hit)
        {
            if(currentInvulnerability > delayInvulnerabilityEnd)
            {
                input.SetDisableInput(false);
                currentInvulnerability = 0;
                hit = false;
            }

            currentInvulnerability += Time.deltaTime;   // add time
        }

    }

    public bool _CanMove = true;
    private void SetDisableInputDelay()
    {
        _CanMove = true;
        rb.constraints = RigidbodyConstraints2D.None;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private bool _CanJumpDelay = true;

    public bool GetCanMove()
    {
        return _CanMove;
    }
    private void CanJumpDelay()
    {
        _CanJumpDelay = true;
    }

    private void SetJumpOn()
    {
        _JumpImput = true;
    }
    
    private void SetJumpOff()
    {
        _JumpImput = false;
    }
    
    private void SetFireOn()
    {
        _FireImput = true;
    }
    
    private void SetFireOff()
    {
        _FireImput = false;
    }
    

    //getter bool run for animator
    public bool GetinputEntercave()
    {
        return inputEntercave;
    }

    public bool GetJumpInput()
    {
        return _JumpImput;
    }
    
    public bool GetFireInput()
    {
        return _FireImput;
    }
    
    //getter bool run for animator
    public bool GetRun()
    {
        return run;
    }


    //getter bool die for animator
    public bool GetDie()
    {
        return die;
    }

    //getter bool hit for animator
    public bool GetHit()
    {
        return hit;
    }


    //Setter bool SetterIsInvulnerable for invulnerabulity
    public void SetterIsInvulnerable(bool onOff)
    {
        IsInvulnerable = onOff;
    }


    //Setter bool SetterDisableInput for disable input 
    public void SetterDisableInput(bool onOff)
    {
        input.SetDisableInput(onOff);
    }

    public void SetterRotate(bool onOff)
    {
        if (onOff)
        {
            _CanMove = false;
        }
        rotate = onOff;
    }

    public void SetterGravityNormal()
    {
        rb.gravityScale = normalGravity;
    }
    
    public bool GetMovementInput()
    {
        return MovementInput != 0;
    }

    // DetecT Envorinement / Ennemy
    void OnTriggerEnter2D(Collider2D other)
    {
        rb.gravityScale = normalGravity;  // return to normal gravity
        canJump = true;    // enable input jump
        jump = false;     // stop event timer jumpe
        currentDelayGravityChange = 0;  // Reset currentDelayGravityChange for next time

        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Ennemy" && !IsInvulnerable)
        {
            if (!hit)
            {
                input.SetDisableInput(true);
                hit = true;   // set true for do Once
                if (GameManagerWizardAndKnight.instance.GetterHardDifficulty())   // check if the difficulty is set to hard
                    Healt -= 2;      // Loose  more healt
                else
                    Healt--;      // Loose healt
                GameManagerWizardAndKnight.instance.SetLifeBarPlayer(Healt);  // check if the difficulty is set to hard

                if (Healt <= 0)    // if he have no healt
                {
                    if(!doOnceDead)
                    {
                        doOnceDead = true;
                        StartCoroutine(levelManager.ChangeLvl(false));     // fade screen to black
                        die = true;               //getter bool die for animator
                        Destroy(gameObject, 6);   // destroy player for don't interfere with next scene
                        input.SetDisableInput(true);     // disable imput while dead
                    }
                }
            }
        }
    }




    //Setter canOpenChest
    public void SetCanOpenChest(bool onOff)
    {
        canOpenChest = onOff;
    }

}

