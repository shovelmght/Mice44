using LesserKnown.Public;
using UnityEngine;
using System.Collections;
using LesserKnown.Camera;
using LesserKnown.TrapsAndHelpers;
using System.Collections.Generic;
using LesserKnown.AI;
using System; 
using SpriteGlow;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace LesserKnown.Player
{
    /// <summary>
    /// This is a custom character controller
    /// It controlls all the player movements and the player behaviours
    /// </summary>
    public class CharacterController2D : MonoBehaviour
    {
        [SerializeField] private float slideJumpForceX;
        [SerializeField] private float slideJumpForceY;
        [SerializeField] private float _SlidingTime = 1;
        [SerializeField] private float slideForce = 10;
        public Animator animOption;
        public GameObject canvaMenu;
        public NewActionInputManager playerInput;
        public int doubble_Jump;
        public int doubble_Jump_in_air;
        public RuntimeAnimatorController anim2;
        public bool vert = true;
        public float vertical;
        public GameObject playerMOvementScript;
        public GameObject uIDistanceScript;     // variable gameobject
        public GameObject UIControlPunch;
        public GameObject UIKeyboradPunch;
        public GameObject UIControlSlide;
        public GameObject UIKeyboradSlide;
        public GameObject UITextSlide;
        public Image UIKeyboradPunchImage;
        public GameObject UIKeyboradSwap;
        public GameObject UIControlSwap;
        public Image UISwapIamge;
        public GameObject UIControlJump;
        public GameObject UIKeyboradClimb;
        public GameObject UIKeyboardJump;
        public GameObject UITextJump;
        public GameObject UIKeyboradPickUp;
        public GameObject UIControllerPickUp;
        public GameObject UITextPickUp;
        private Rigidbody2D rb;
        public bool setIsMenuOn;
        private Collider2D p_collider;
        private SpriteRenderer player_sprite;
        private AnimManager anim_manager;
        private CharacterController2D other_player;
        private Animator anim;
        public bool _IsKeyboard { get; private set;}
        [SerializeField] private Button _returnButton;
        private bool _DoOnceUISwap;

        private const float FILL_AMOUT_COVER_KEY = 0.652f;

        /// <summary>
        /// This is the CameraFollow script from LesserKnown.Camera attatched to the camera
        /// </summary>
        private CameraFollow cam;

        [Header("Layers")]
        [Tooltip("Used to detect the terrain")]
        public LayerMask ground;
        [Tooltip("Used to detect the platforms")]
        public LayerMask platform;
        [Tooltip("Used to detect enemies")]
        public ContactFilter2D enemy_filter;

        [Space(10)]
        [Header("Modifiers")]
        [Range(1f, 2f)]
        /// <summary>
        /// This is the fall speed modifier
        /// </summary>
        public float fall_modifier;

        [Space(10)]
        [Header("Objects Holder")]
        public Transform box_placer;
        [HideInInspector]
        public BoxControl current_picked_box;

        [Space(10)]
        // private PlayerNetwork player_network;

        /// <summary>
        /// This checks if the player can do a wall jump
        /// </summary>
        [HideInInspector]
        public bool wall_jump;
        /// <summary>
        /// The modifier for the wall jump, depending on it's direction
        /// </summary>
        private float touching_wall;
        /// <summary>
        /// Verifies if the player can climb a ladder
        /// </summary>
        private bool can_climb_ladder;
        /// <summary>
        /// Verifies if the player is climbing a ladder
        /// </summary>
        [HideInInspector]
        public bool is_climbing_ladder;
        /// <summary>
        /// This is for testing only, activate to not take damage
        /// Still need to implement it
        /// </summary>
        [HideInInspector]
        public bool is_invicible;
        /// <summary>
        /// Verfies if the player is looking right or left
        /// It's for local use only, in network you need to use the network variable
        /// </summary>
        private bool local_left;

        /// <summary>
        /// Verifies if the player has an object in hands
        /// </summary>
        private bool is_holding_object;

        /// <summary>
        /// Verifies if the player is over a box trigger
        /// </summary>
        public bool can_pick_up;

        public bool horizontalEnable;
        public bool verticalEnable;

        private bool cannot_jump;
        public bool _IsJumping;
        public bool _IsPunching;
        private bool _SlideIsPress;


        /// <summary>
        /// These boundaries detect if the player is touching something and from what direction
        /// </summary>
        #region Player Boundaries
        [Space]
        [Header("Player Options")]
        public bool is_active;
        public bool is_fighter;
        public GameObject player_indicator;
        public GameObject lifeBar;
        public GameObject gameOverRespawn;

        [Space(10)]
        [Header("Boundaries Ground")]
        public Vector2 boundary_size;
        public Vector2 boundary_placement;
        
        [Space(10)]
        [Header("Boundaries Ground")]
        public Vector2 boundary_sizeForWall;


        [Space(10)]
        [Header("Boundaries Right")]
        public Vector2 boundary_size_r;
        public Vector2 boundary_placement_r;

        [Space(10)]
        [Header("Boundaries Left")]
        public Vector2 boundary_size_l;
        public Vector2 boundary_placement_l;
        #endregion
        [SerializeField] private Color deathScreenColor;
        
        private void Awake()
        {
            playerInput = new NewActionInputManager();
        }
        private void OnEnable()
        {
            playerInput.Enable();
        }
        private void OnDisable()
        {
            playerInput.Disable();
        }
        private void Start()
        {
            playerInput.SoulRunner.Swap.performed += _ => ControllerSwapCharacter();
            playerInput.SoulRunner.Jump.performed += _ => JumpPress();
            playerInput.SoulRunner.Jump.canceled += _ => JumpUnPress();
            playerInput.SoulRunner.Punch.performed += _ => PunchPress();
            playerInput.SoulRunner.Punch.canceled += _ => PunchUnPress();
            playerInput.SoulRunner.Start.performed += _ => OptionCanva();
            playerInput.SoulRunner.Slide.performed += _ => SlidePress();
            playerInput.SoulRunner.Slide.canceled += _ => SlideUnPress();
            
            //playerInput.BulletHell.Option.canceled += _ => SwapCharacter();
            horizontalEnable = true;
            rb = GetComponent<Rigidbody2D>();
            player_sprite = GetComponent<SpriteRenderer>();
            anim_manager = GetComponent<AnimManager>();
            lifeBar.SetActive(false);
            gameOverRespawn.SetActive(false);

            //This is for network use only, it's not for this project
            // player_network = GetComponent<PlayerNetwork>();
            p_collider = GetComponent<Collider2D>();
            cam = UnityEngine.Camera.main.GetComponent<CameraFollow>();

            Swap_Character();
            ChangeLayer();  //-change layer to player/terrain for character can jump head of each other

            CharacterController2D[] players = FindObjectsOfType<CharacterController2D>();

            foreach (var player in players)
            {
                if (player != this)
                    other_player = player;
            }
            
           
            StartCoroutine(Swap_Character());
        }
        
        private void JumpPress()
        {
            if (!setIsMenuOn && !PublicVariables.IS_IN_PAUSE_MENU)
            {
                _IsJumping = true;
            }
            
        }
        
        private void JumpUnPress()
        {
            _IsJumping = false;
        }
        
        private void PunchPress()
        {
            _IsPunching = true;
        }
        
        private void SlidePress()
        {
            if (!setIsMenuOn && !PublicVariables.IS_IN_PAUSE_MENU)
            {
                _SlideIsPress = true;
            }
        }
        
        private void SlideUnPress()
        {
            if (!setIsMenuOn && !PublicVariables.IS_IN_PAUSE_MENU)
            {
                _SlideIsPress = false;
            }
        }
        private void PunchUnPress()
        {
            _IsPunching = false;
        }
        
        private void OptionCanva()
        {
            if (is_active)
            {
              Debug.Log(gameObject.name);
                if (!setIsMenuOn)
                {
                    Cursor.lockState = CursorLockMode.None;
                    setIsMenuOn = true;
                    PublicVariables.IS_IN_PAUSE_MENU = true;
                    animOption.SetBool("In", true);
                    animOption.SetBool("Out", false);
                    _returnButton.Select();

                }
                else
                {
                    Time.timeScale = 1;
                    PublicVariables.IS_IN_PAUSE_MENU = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    Invoke(nameof(SetIsMenuOff), 1);
                    animOption.SetBool("In", false);
                    animOption.SetBool("Out", true);
                }
            }
        }

        private void SetIsMenuOff()
        {
            PublicVariables.IS_IN_PAUSE_MENU = false;
            setIsMenuOn = false;
        }

        private bool _IsSliding;
        public void OptionCanvaReturn()
        {
            Debug.Log(gameObject.name);
            if (is_active)
            {
                Invoke(nameof(SetIsMenuOff), 0.5f);
                animOption.SetBool("In", false);
                animOption.SetBool("Out", true);

            }
        }

        private IEnumerator SetSliding()
        {
            if (!_IsSliding)
            {
                _SlideIsPress = false;
                anim_manager.Slide(true);
                _IsSliding = true;
                yield return new WaitForSeconds(_SlidingTime);
                bool canMove = false;

 
                while (!canMove)
                {
                    yield return null;
                    canMove = IsGrounded();

                    if (!canMove)
                    {
                        canMove = IsOnPlatform();
                    }
                }
                _IsSliding = false;
                anim_manager.Slide(false);
            }
            
        }

        public float minMagnitudeRunAnimation;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) || _SlideIsPress)
            {
                if (is_active && !is_fighter)
                {
                    if (local_left)
                    {
                        rb.velocity = new Vector2(-slideForce, rb.velocity.y);
                    }
                    else
                    {
                        rb.velocity = new Vector2(slideForce, rb.velocity.y);
                    }
                    
                    
                    StartCoroutine(SetSliding());
                }
                
                
            }
            
            if (!is_fighter)
            {
                if (current_picked_box != null )
                {
                    float dist = Vector3.Distance(current_picked_box.transform.position, transform.position);
                    if (dist > 1)
                    {
                        can_pick_up = false;
                        UIKeyboradPickUp.SetActive(false);
                        UIControllerPickUp.SetActive(false);
                        UITextPickUp.SetActive(false);
                    }
                }
                
            }
            if (!is_fighter && (IsTouchingLeft() || IsTouchingRight()) && !IsGroundedForWallJump())
            {
                if (_IsKeyboard)
                {
                    if (!PublicVariables.IS_FUSIONED)
                    {
                        UIKeyboardJump.SetActive(true);
                    }
                    
                    UIControlJump.SetActive(false);
                }
                else
                {
                    if (!PublicVariables.IS_FUSIONED)
                    {
                        UIControlJump.SetActive(true);
                    }
                    
                    UIKeyboardJump.SetActive(false);
                }

                if (!PublicVariables.IS_FUSIONED)
                {
                    UITextJump.SetActive(true);
                }
                
            }
            else
            {
                UIKeyboardJump.SetActive(false);
                UIControlJump.SetActive(false);
                UITextJump.SetActive(false);
            }
            if (vert)
            {
                vertical = Input.GetAxisRaw("Vertical");

            }
            else
                vertical = 0;


            //player_sprite.flipX = player_network.left;
            player_sprite.flipX = local_left;

            //This changes the y velocity when touching a wall so it gives the feeling the player is sliding on the wall
            if (IsWallFalling())
            {
                if (!is_fighter)
                {
                    rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y / fall_modifier);
                }
                if (is_climbing_ladder)
                {
                    rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y / fall_modifier);
                }
            
                
            }
               // 

            Climbing_Ladder();

            //This flips the sprite according to the moving direction
            if (IsWallFalling() && IsTouchingLeft())
                Flip(false);
            else if (IsWallFalling() && IsTouchingRight())
                Flip(true);

            

            //This triggers the move animation
            //anim_manager.Move(rb.velocity.magnitude > 0 && (IsGrounded() || IsOnPlatform()));
            anim_manager.Move(rb.velocity.magnitude > minMagnitudeRunAnimation);

            if (IsGrounded())
                doubble_Jump = 2;
            if (!IsGrounded())
                doubble_Jump = 0;



            //This is the indicator on top of the player
            player_indicator.SetActive(is_active);

            if (PublicVariables.IS_FUSIONED)
            {
                //disabled the symbol player indicator
                SpriteRenderer indicatorImage = player_indicator.GetComponent<SpriteRenderer>();
                indicatorImage.enabled = false;
                
                if (_IsKeyboard)
                {
                    UIControlPunch.SetActive(false);
                    UIKeyboradPunch.SetActive(true);
                    UIControlSlide.SetActive(false);
                    UIKeyboradSlide.SetActive(true);
                    UITextSlide.SetActive(true);
                    UIKeyboradPunchImage.fillAmount = 1;
                }
                else
                {
                    UIKeyboradPunch.SetActive(false);
                    UIControlPunch.SetActive(true);
                    UITextSlide.SetActive(true);
                    UIKeyboradSlide.SetActive(false);
                    UIControlSlide.SetActive(true);
                    UIKeyboradPunchImage.fillAmount = FILL_AMOUT_COVER_KEY;
                }
                
                
                Destroy(uIDistanceScript);
                setLayerController(6);

            }


            if (Input.GetKeyDown(KeyCode.C))
            {
                if(!setIsMenuOn && !PublicVariables.IS_IN_PAUSE_MENU)
                {
                    UIKeyboradClimb.SetActive(false);
                    vertical = 0;
                    if (_DoOnceUISwap)
                    {
                        UI_Collectible.Instance.SetCollectibleAnimator("Coin");
                        UIControlPunch.SetActive(false);
                        UIKeyboradPunch.SetActive(false);
                        if (_IsKeyboard)
                        {
                            UIControlSlide.SetActive(false);
                            UIKeyboradSlide.SetActive(true);
                        }
                        else
                        {
                            UIControlSlide.SetActive(true);
                            UIKeyboradSlide.SetActive(false);
                        }
                        UITextSlide.SetActive(true);
                        _DoOnceUISwap = false;
                    }
                    else
                    {
                        UI_Collectible.Instance.SetCollectibleAnimator("Apple");
                        UITextSlide.SetActive(false);
                        UIKeyboradSlide.SetActive(false);
                        UIControlSlide.SetActive(false);
                        if (_IsKeyboard)
                        {
                            UIControlPunch.SetActive(false);
                            UIKeyboradPunch.SetActive(true);
                            UIKeyboradPunchImage.fillAmount = 1;
                        }
                        else
                        {
                            UIKeyboradPunch.SetActive(true);
                            UIControlPunch.SetActive(true);
                            UIKeyboradPunchImage.fillAmount = FILL_AMOUT_COVER_KEY;
                        }
                        _DoOnceUISwap = true;
                    }

                    //Input.GetAxisRaw("Vertical") = 0;
                    StartCoroutine(Swap_Character());

                    ChangeLayer();  //change layer to player/terrain for character can jump head of each other 
                }
            }
            
            float keyboardValue = playerInput.ArcadeMain1.DetectKeyboadAD.ReadValue<float>();
            float controllerValue = playerInput.ArcadeMain1.DetectControllerXboxLeftStick.ReadValue<float>();

            if (keyboardValue != 0)
            {

                if (PublicVariables.IS_FUSIONED)
                {
                    UIControlSwap.SetActive(false);
                    UIKeyboradSwap.SetActive(false);
                    UIKeyboradSlide.SetActive(true);
                }
                else
                {
                    UIControlSwap.SetActive(false);
                    UIControlPunch.SetActive(false);
                    UIKeyboradPunchImage.fillAmount = 1;
                    _IsKeyboard = true;
                    UISwapIamge.fillAmount = 1;
                    if (!is_fighter)
                    {
                        if (is_active)
                        {
                            UIKeyboradSlide.SetActive(true);
                        }
                       
                        UIControlSlide.SetActive(false);
                    }
                    else
                    {
                        UIKeyboradSlide.SetActive(false);
                        UIControlSlide.SetActive(false);
                    }
                }
           
            }
            else if (controllerValue != 0)
            {
                if (PublicVariables.IS_FUSIONED)
                {
                    UIControlSwap.SetActive(false);
                    UIKeyboradSwap.SetActive(false);
                    UIControlSlide.SetActive(true);
                }
                else
                {
                    UISwapIamge.fillAmount = FILL_AMOUT_COVER_KEY;
                    UIControlSwap.SetActive(true);
                    _IsKeyboard = false;
                    if (!is_fighter)
                    {
                        if (is_active)
                        {
                            UIControlSlide.SetActive(true);
                        }
                        UIKeyboradSlide.SetActive(false);
                    }
                    else
                    {
                        UIControlSlide.SetActive(false);
                        UIKeyboradSlide.SetActive(false);
                    }
                }
            }
        }

        private void ControllerSwapCharacter()
        {
            
            if(!setIsMenuOn && !PublicVariables.IS_IN_PAUSE_MENU)
            {
                UIKeyboradClimb.SetActive(false);
                vertical = 0;
                if (_DoOnceUISwap)
                {
                    UI_Collectible.Instance.SetCollectibleAnimator("Coin");
                    UIControlPunch.SetActive(false);
                    UIKeyboradPunch.SetActive(false);
                    UIKeyboradPunch.SetActive(false);
                    if (_IsKeyboard)
                    {
                        UIControlSlide.SetActive(false);
                        UIKeyboradSlide.SetActive(true);
                    }
                    else
                    {
                        UIControlSlide.SetActive(true);
                        UIKeyboradSlide.SetActive(false);
                    }
                    UITextSlide.SetActive(true);
                    _DoOnceUISwap = false;
                }
                else
                {
                    UI_Collectible.Instance.SetCollectibleAnimator("Apple");
                    UITextSlide.SetActive(false);
                    UIKeyboradSlide.SetActive(false);
                    UIControlSlide.SetActive(false);
                    if (_IsKeyboard)
                    {
                        UIControlPunch.SetActive(false);
                        UIKeyboradPunch.SetActive(true);
                        UIKeyboradPunchImage.fillAmount = 1;
                    }
                    else
                    {
                        UIKeyboradPunch.SetActive(true);
                        UIControlPunch.SetActive(true);
                        UIKeyboradPunchImage.fillAmount = FILL_AMOUT_COVER_KEY;
                    }
                    _DoOnceUISwap = true;
                }
                
                //Input.GetAxisRaw("Vertical") = 0;
                StartCoroutine(Swap_Character());

                ChangeLayer();  //change layer to player/terrain for character can jump head of each other 
            }
        }


        private void SwapCharacter()
        {
            if(!setIsMenuOn && !PublicVariables.IS_IN_PAUSE_MENU)
            {
                vertical = 0;


                //Input.GetAxisRaw("Vertical") = 0;
                StartCoroutine(Swap_Character());

                ChangeLayer();  //change layer to player/terrain for character can jump head of each other 
            }
        }

        /// <summary>
        /// Changes the player collider when climbing a ladder
        /// When on the ladder it's trigger so it doesn't interact with the terrain
        /// This is done for the platforms when you need to go down
        /// </summary>
        private void Climbing_Ladder()
        {
            if (is_climbing_ladder)
            {
                p_collider.isTrigger = true;
                rb.gravityScale = 0f;

            }

            else
            {
                p_collider.isTrigger = false;
                rb.gravityScale = 6.5f;

            }
        }


        /// <summary>
        /// Swaps the player
        /// </summary>
        IEnumerator Swap_Character()
        {
            vert = false;
            vertical = 0;
            vertical = 0;
            yield return new WaitForSeconds(0.1f);
            vert = true;

            if (PublicVariables.IS_FUSIONED && is_fighter)
            {
                is_active = !is_active;
            }
            else if (PublicVariables.IS_FUSIONED && !is_fighter)
            {
                cam.Set_Camera_Local(transform);
            }

            else if (!PublicVariables.IS_FUSIONED)
            {

                is_active = !is_active;

                if (is_active)
                    cam.Set_Camera_Local(transform);
            }
            SwapGlow();
        }
        // change layer to player/terrain for character can jump head of each 
        public void ChangeLayer()
        {

                if (is_active)
                {
                StartCoroutine(ChangeLayer_1());

                }
                if (!is_active)
                {

                StartCoroutine(ChangeLayer_2());
                }
            
        }


        public void setLayerController(int layer)
        {
            gameObject.layer = layer;
        }

        public void SwapGlow()
        {
            SpriteGlowEffect glow = GetComponent<SpriteGlowEffect>();
            if(glow)
                glow.enabled = is_active;
            //other_player.SwapGlow();
        }

        /// <summary>
        /// Move player, also checks for all the movement changes
        /// </summary>
        /// <param name="movement_speed">The player movement speed</param>
        public void Move(float movement_speed)
        {
            if (wall_jump  || anim_manager.Has_Stop_Animation())
                return;

            anim_manager.Climb(false);
            anim_manager.Climb_Stay(false);

            if (movement_speed != 0)
            {

                if (is_climbing_ladder)
                {
                    movement_speed /= 3;
                    anim_manager.Climb(true);
                }
            }
            //is_climbing_ladder = false;

            if (!IsGroundedForWallJump() && !IsOnPlatform())
            {
                if (IsTouchingRight())
                {
                    if (movement_speed > 0)
                        return;
                }

                if (IsTouchingLeft())
                {
                    if (movement_speed < 0)
                        return;
                }
            }


            if (!_IsSliding)
            {
                rb.velocity = new Vector2(movement_speed, rb.velocity.y);
            }

        

            if (movement_speed > 0)
                Flip(false);
            else if (movement_speed < 0)
                Flip(true);
        }

        /// <summary>
        /// Frank : used by Spike Traps script
        /// </summary>
        /// 
        public void DonTMovePlsDuringFusion()
        {
            StartCoroutine(DontMoveFustion());

        }

        public void Dead()
        {

            anim_manager.Die_Anim();
            if(!PublicVariables.IS_FUSIONED)
                Reset_Position();
            else
            {
                StartRepawn();
                //Destroy(gameObject, 0.5f); //ca BUG trop les choses si je fais ca 
                //ATM, you reset until you beat boss
            }
        }

        private void Reset_Position()
        {

            StartCoroutine(Delaydeath());


        }
        private void StartRepawn()
        {
            gameOverRespawn.SetActive(false);
            StartCoroutine("Respawn");
            gameOverRespawn.SetActive(true);
            transform.position = gameOverRespawn.transform.position;
            PublicVariables.Reset_Health();

        }
        private IEnumerator Respawn() 
        {
            //just a delay for when you respawn
            yield return new WaitForSeconds(1f);
        }

        public void Get_Hit(int amount)
        {
            if (is_invicible)
                return;
            is_invicible = true;
            anim_manager.Get_Hit();
            bool death = PublicVariables.Lose_Health(amount);

            if (death)
            {
                Dead();
                //Disable Network Player
            }

            StartCoroutine(Reset_InvicibilityIE());
        }

        private IEnumerator Reset_InvicibilityIE()
        {
            yield return new WaitForSeconds(1.5f);
            is_invicible = false;
        }

        public void Climb(float movement_speed)
        {
            if (is_holding_object)
                return;

            if (movement_speed > 0.5f || movement_speed < -0.5f)
                is_climbing_ladder = true;


            if (!can_climb_ladder)
            {
                is_climbing_ladder = false;
                return;
            }

            if (!is_climbing_ladder)
                return;

            if (movement_speed == 0 && rb.velocity == Vector2.zero)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0f);
                anim_manager.Climb_Stay(true);
                return;
            }

            anim_manager.Climb_Stay(false);
            anim_manager.Climb(true);
            rb.velocity = new Vector2(rb.velocity.x, movement_speed);
        }

        private void Flip(bool left)
        {
            /* Set left on network
            player_network.left = left;            */

            local_left = left;
        }
        
        /// <summary>
        /// Does the player jump
        /// </summary>
        /// <param name="jump_force">The jump force</param>
        /// <param name="move_speed">The jump force used to jump when next to a wall</param>
        public void Jump(float jump_force)
        {
            _IsJumping = false;
            if (!cannot_jump )
            {
                if (is_holding_object || anim_manager.Has_Stop_Animation())
                    return;

                if (IsTouchingLeft())
                    touching_wall = 1;
                else if (IsTouchingRight())
                    touching_wall = -1;

                if ((IsTouchingLeft() || IsTouchingRight()) && !IsGroundedForWallJump())
                    wall_jump = true;

                if (wall_jump)
                {
                    Invoke("Wall_Jump", 0.08f);

                    StartCoroutine(DontMove());
                    StartCoroutine(SetCanJumpAfterWallJump());
                }
                if (PublicVariables.IS_FUSIONED && doubble_Jump == 2 && doubble_Jump_in_air == 1)
                {
                    
                    rb.velocity = new Vector2(rb.velocity.x, jump_force);
                    doubble_Jump_in_air = 0;
                    anim_manager.Double_Jump_Anim();
                }

                if (!IsOnPlatform())
                {
                    if (!IsGrounded())
                    {
                        if (!is_climbing_ladder)
                        {
                            return;
                        }
                        
                    }
                }

                anim_manager.Jump_Anim();

                if (!PublicVariables.IS_FUSIONED)
                {
                    //rb.velocity = new Vector2(rb.velocity.x, jump_force);

                }

                if (_IsSliding)
                {
                    if (local_left)
                    {
                        rb.velocity = new Vector2(rb.velocity.x + -slideJumpForceX, jump_force + slideJumpForceY);
                    }
                    else
                    {
                        rb.velocity = new Vector2(rb.velocity.x + slideJumpForceX, jump_force + slideJumpForceY);
                    }
                    
                }
                else
                {
                    if (is_fighter && touching_wall > 0 )
                    {
                        Debug.Log(rb.velocity.y);
                        if (anim_manager.GetIsWallSlide())
                        {
                            return;
                        }
                        
                    }
                    rb.velocity = new Vector2(rb.velocity.x, jump_force);
                }
                
                if(PublicVariables.IS_FUSIONED)
                doubble_Jump_in_air = 1;


                anim_manager.Climb(false);
                anim_manager.Climb_Stay(false);
                is_climbing_ladder = false;

            }

        }

        public IEnumerator SetCanJumpAfterWallJump()
        {
            if (!cannot_jump)
            {
                cannot_jump = true;
                yield return new WaitForSeconds(0.25f);
                cannot_jump = false;
            }
        }

        public IEnumerator DontMove()
        {

            cannot_jump = true;
            horizontalEnable = false; //--------------------------------------------tell if player can move
            yield return new WaitForSeconds(0.25f);
           
            horizontalEnable = true;
            yield return new WaitForSeconds(0.25f);
            cannot_jump = false;

        }
        public IEnumerator DontMoveFustion()
        {
            cannot_jump = true;
            horizontalEnable = false;  //--------------------------------------------tell if player can move
            yield return new WaitForSeconds(2.25f);
            anim = GetComponent<Animator>();
            anim.runtimeAnimatorController = anim2;
            horizontalEnable = true;
            cannot_jump = false;

        }
        public IEnumerator Delaydeath()
        {
            horizontalEnable = false; //--------------------------------------------tell if player can move
            yield return new WaitForSeconds(0.25f);
            DistanceUI uIDistance = uIDistanceScript.GetComponent<DistanceUI>();   
            StartCoroutine(CameraShaker.Instance.Shake());
            StartCoroutine(FlashWhiteScreenManager._Instance.Flash(deathScreenColor));
            if (uIDistance._Distance > uIDistance.maxDist )
            {
                transform.position = new Vector3(-25, -3.5f, 0);

            }
            else
            {
                StartCoroutine("Respawn");
                transform.position = other_player.transform.position +  new Vector3(0,1,0);
            }

            horizontalEnable = true;

        }
        public IEnumerator ChangeLayer_1()
        {

            yield return new WaitForSeconds(0.65f);
            setLayerController(3); //player
  

        }
        public IEnumerator ChangeLayer_2()
        {

            yield return new WaitForSeconds(0.65f);
            setLayerController(6); //player


        }

        public void Jump_Wall(Vector2 jump_force)
        {
            if (jump_force.x == 0)
                return;

            rb.velocity = new Vector2(jump_force.x * touching_wall, jump_force.y);
        }

        private void Wall_Jump()
        {
            wall_jump = false;
        }

        #region Public bools
        /// <summary>
        /// Verifies if the player is touching any object with the Layer Terrain bottom
        /// </summary>
        public bool IsGrounded()
        {

            return Physics2D.OverlapBox(new Vector2(transform.position.x + boundary_placement.x, transform.position.y - boundary_placement.y), new Vector2(boundary_size.x, boundary_size.y), 0f, ground);

        }
        
        public bool IsGroundedForWallJump()
        {

            return Physics2D.OverlapBox(new Vector2(transform.position.x + boundary_placement.x, transform.position.y - boundary_placement.y), new Vector2(boundary_sizeForWall.x, boundary_sizeForWall.y), 0f, ground);

        }

        public bool IsOnPlatform()
        {

            return Physics2D.OverlapBox(new Vector2(transform.position.x + boundary_placement.x, transform.position.y - boundary_placement.y), new Vector2(boundary_size.x, boundary_size.y), 0f, platform);

        }

        /// <summary>
        /// Verifies if the player is touching any object with Layer Terrain on left
        /// </summary>
        public bool IsTouchingLeft()
        {

            return Physics2D.OverlapBox(new Vector2(transform.position.x - boundary_placement_l.x, transform.position.y - boundary_placement_l.y), new Vector2(boundary_size_l.x, boundary_size_l.y), 0f, ground);

        }

        /// <summary>
        /// Verifies if the player is touching any object with Layer Terrain on right
        /// </summary>
        public bool IsTouchingRight()
        {
            return Physics2D.OverlapBox(new Vector2(transform.position.x + boundary_placement_r.x, transform.position.y - boundary_placement_r.y), new Vector2(boundary_size_r.x, boundary_size_r.y), 0f, ground);

        }

        /// <summary>
        /// Verifies if the player is falling next to a wall
        /// </summary>
        public bool IsWallFalling()
        {
            bool isWallFalling = (IsTouchingLeft() || IsTouchingRight()) && !IsGroundedForWallJump();
            if (isWallFalling)
            {
                if (rb.velocity.magnitude < minMagnitudeRunAnimation)
                {
                    isWallFalling = false;
                }
            }

            return isWallFalling;
        }
        #endregion
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Ladder")
                can_climb_ladder = true;

            if (collision.tag == "Box" && !is_holding_object)
            {
                
                current_picked_box = collision.gameObject.GetComponent<BoxControl>();
                if (_IsKeyboard)
                {
                    if (!PublicVariables.IS_FUSIONED)
                    {
                        UIKeyboradPickUp.SetActive(true);
                    }
                    
                    UIControllerPickUp.SetActive(false);
                }
                else
                {
                    UIKeyboradPickUp.SetActive(false);
                    UIControllerPickUp.SetActive(true);
                }

                if (!is_fighter)
                {
                    UITextPickUp.SetActive(true);
                    can_pick_up = true;
                }
                
            }
            // Fighter or Fusioned Player can climb trees
            if (collision.tag == "LadderTree" && is_fighter)
            {
                can_climb_ladder = true;
                UIKeyboradClimb.SetActive(true);
            }
            
            //Fighter or Fusioned Player can climb trees
            if (collision.tag == "LadderTree" && PublicVariables.IS_FUSIONED)
            {
                can_climb_ladder = true;
                UIKeyboradClimb.SetActive(true);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag == "Ladder")
                can_climb_ladder = false;

            if (collision.tag == "Box"&& !is_holding_object)
            {
                current_picked_box = collision.gameObject.GetComponent<BoxControl>();
                can_pick_up = false;
                UIKeyboradPickUp.SetActive(false);
                UIControllerPickUp.SetActive(false);
                UITextPickUp.SetActive(false);
            }

            //Fighter or Fusioned Player can climb trees
            if (collision.tag == "LadderTree" && is_fighter)
            {
                can_climb_ladder = false;
                UIKeyboradClimb.SetActive(false);
            }
            
            //Fighter or Fusioned Player can climb trees
            if (collision.tag == "LadderTree" && PublicVariables.IS_FUSIONED)
            {
                can_climb_ladder = false;
                UIKeyboradClimb.SetActive(false);
            }
        }

        private void Send_Hit()
        {
            List<RaycastHit2D> hits = new List<RaycastHit2D>();
            
            if (local_left)
            {
                Physics2D.Raycast(transform.position - new Vector3(0,0.75f,0), -transform.right, enemy_filter, hits, 1.5f);
            }
            else if (!local_left)
            {
                Physics2D.Raycast(transform.position  - new Vector3(0,0.75f,0), transform.right, enemy_filter, hits, 1.5f);
            }
            
            if (hits.Count > 0)
            {
                hits[0].transform.GetComponent<Enemy_Interface>().Get_Hit(1);
            }
                
        }

        public Rigidbody2D GetRigidbody2D()
        {
            return rb;
        }

        #region Warrior Region
        public void Attack()
        {
            if (anim_manager.Is_Attacking())
                return;

            anim_manager.Attack();
        }
        #endregion

        #region Solver Region
        public void Pickup()
        {
            if (anim_manager.Has_Stop_Animation() || !can_pick_up)
                return;
      
            if (!is_holding_object)
                current_picked_box.Start_Animation(anim_manager);
            else
            {
           
                current_picked_box.Throw();
                StartCoroutine(Throw2());
            }
             


            is_holding_object = !is_holding_object;
            anim_manager.Pick_Throw(is_holding_object);
        }
        public IEnumerator Throw2()
        {

            yield return new WaitForSeconds(0.25f);
            can_pick_up = false;

        }


        public bool IsLookingLeft()  // --------------------- for throw box right or left
        {

            return local_left;

        }
        #endregion

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawCube(new Vector2(transform.position.x + boundary_placement.x, transform.position.y - boundary_placement.y), new Vector2(boundary_size.x, boundary_size.y));

            Gizmos.color = Color.blue;
            Gizmos.DrawCube(new Vector2(transform.position.x - boundary_placement_l.x, transform.position.y - boundary_placement_l.y), new Vector2(boundary_size_l.x, boundary_size_l.y));

            Gizmos.color = Color.yellow;
            Gizmos.DrawCube(new Vector2(transform.position.x + boundary_placement_r.x, transform.position.y - boundary_placement_r.y), new Vector2(boundary_size_r.x, boundary_size_r.y));

        }

    }
}