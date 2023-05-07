using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    [SerializeField]
    private MouseMovement mouse;
    [SerializeField]
    private GameObject canvaOption;
    [SerializeField]
    private GameObject canvaEsc;
    [SerializeField]
    private Animator animCanvas;
    [SerializeField]
    private GameObject camBulletHell;
    [SerializeField]
    private GameObject joystic;
    [SerializeField]
    private VideoChanger videoChanger;
    [SerializeField]
    private SceneChanger sceneChanger;
    [SerializeField]
    private EventSystem eventSystem;
    [SerializeField]
    private GameObject firstButton;


    public Rigidbody rb;
    public NewActionInputManager playerInput;
    public Animator animMouse;
    public float maxDistanceRaycast = 4;
    public float maxDistanceRaycastFwrd = 1;
    public float normalSpeed;
    public float speedOnArcade;
    public float speedClimb;
    public float dist;
    public float dist2;
    public float speedAnim;
    private float speed;
    private bool nearJoystick = false;
    private bool canMove = true;
    private bool isGrounded = false;
    private bool isClimbing = false;


    void Start()
    {
        eventSystem = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<EventSystem>();
        eventSystem.firstSelectedGameObject = firstButton;
        playerInput.ArcadeMain.Action.performed += _ => Action();
        playerInput.ArcadeMain.Option.performed += _ => OptionCanva();
        rb = GetComponent<Rigidbody>();
        canvaEsc = GameObject.FindGameObjectWithTag("Esc");
        canvaOption = GameObject.FindGameObjectWithTag("CanvasOption");
        animCanvas = GameObject.FindGameObjectWithTag("Pannel").GetComponent<Animator>();
        canvaOption.SetActive(false);
    }


    private void Action()
    {
        if (nearJoystick)
        {
            canMove = false;
            animMouse.SetTrigger("take");
            joystic.GetComponent<JoystickInteraction>().PlayArcade();
        }
    }

    private void OptionCanva()
    {
        playerInput.Disable();
        mouse.SetIsMenuOn();
        canvaOption.SetActive(true);
        animCanvas.SetTrigger("in");
    }

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

    // Update is called once per frame
    void Update()
    {

        Vector3 dwn = transform.TransformDirection(Vector3.down);
        RaycastHit hit;

        if (Physics.Raycast(transform.position + new Vector3(0, dist2, dist), dwn, out hit, maxDistanceRaycast))
        {
           
            if (hit.collider.CompareTag("Arcade"))
            {
                speed = speedOnArcade;
                isGrounded = true;
            }
            else if(hit.collider.CompareTag("Floor"))
            {
                isGrounded = true;
                speed = normalSpeed;
            }
            else
            {
                speed = normalSpeed;
            }
        }
        else
        {
            isGrounded = false;
        }
            animMouse.SetFloat("SpeedAnim", speed);

        Debug.DrawRay(transform.position + new Vector3(0, 0.23f, dist), dwn * maxDistanceRaycast, Color.yellow);

        animMouse.SetFloat("Movement", playerInput.ArcadeMain.MoveY.ReadValue<float>());
        animMouse.SetFloat("MovementX", playerInput.ArcadeMain.MoveX.ReadValue<float>());
        float movementInputX = playerInput.ArcadeMain.MoveX.ReadValue<float>();
        float movementInputY = playerInput.ArcadeMain.MoveY.ReadValue<float>();

        if (isClimbing)
        {
            animMouse.SetFloat("SpeedClimb", (movementInputY * speedAnim));
            transform.position += new Vector3(0, movementInputY, 0) * speedClimb * Time.deltaTime;
            mouse.enabled = false;
            rb.useGravity = false;

            if (movementInputY < 0 && isGrounded)
            {
          
                ReturnToWalkMode();
            }
        }
        if(canMove)
        {
            rb.MovePosition(rb.position + transform.rotation * new Vector3(movementInputX, 0, movementInputY) * speed * Time.deltaTime);
            mouse.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Arcade"))
        {
            animMouse.SetBool("IsClimbing", true);

            isClimbing = true;
            rb.useGravity = false;
        }
        else if (other.CompareTag("Joystick"))
        {
            joystic = other.gameObject;
            nearJoystick = true;
            other.gameObject.GetComponent<JoystickInteraction>().SpawnCancas(mouse.getIsKeyboard());
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Arcade"))
        {
            ReturnToWalkMode();
        }
        else if (other.CompareTag("Joystick"))
        {
            nearJoystick = false;
            other.gameObject.GetComponent<JoystickInteraction>().DestroyCancas();
        }
    }

    public void ReturnToWalkMode()
    {
        speed = 1;
        animMouse.SetBool("IsClimbing", false);
        isClimbing = false;
        rb.useGravity = true; ;
    }
}
