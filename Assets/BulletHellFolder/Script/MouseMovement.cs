using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    [SerializeField]
    private Player player;
    public float mouseSensitivity { get; set; }
    public Transform playerBody;
    public float mouseX;
    public float xboxSpeedMouvement;
    public float StartMouseMOuvement;
    public NewActionInputManager playerInput;
    private bool isMenu = false;
    private bool isKeyboard ;
    [SerializeField]
    private Animator animator;


    void Start()
    {
        mouseSensitivity = StartMouseMOuvement;
        Cursor.lockState = CursorLockMode.Locked;            // lock the cursor
    }

    private void Awake()
    {
        playerInput = new NewActionInputManager();
    }

    private void OnEnable()
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
        float mouseValue = playerInput.ArcadeMain1.CameraControl.ReadValue<float>();
        float controllerValue = playerInput.ArcadeMain1.CameraControlXbox.ReadValue<float>();

        if (mouseValue != 0)
        {
            float rotationX = transform.localEulerAngles.y + mouseValue * mouseSensitivity * Time.deltaTime;
            isKeyboard = true;
            transform.localEulerAngles = new Vector3(0, rotationX, 0);
        }
       else if (controllerValue != 0)
        {
            float rotationX = transform.localEulerAngles.y + controllerValue * (mouseSensitivity + xboxSpeedMouvement) * Time.deltaTime;
            isKeyboard = false;
            transform.localEulerAngles = new Vector3(0, rotationX, 0);
        }
    
        
    }

    public void SetIsMenuOn()
    {
        isMenu = true;
        Cursor.lockState = CursorLockMode.None;
        playerInput.Disable();
    }

    public void SetIsMenuOff()
    {
        isMenu = false;
        Cursor.lockState = CursorLockMode.Locked;
        animator.ResetTrigger("in");
        animator.SetTrigger("out");
        player.OnEnable();
        playerInput.Enable();
    }

    public void SetSensivity(float newSensivity)
    {
        mouseSensitivity = newSensivity;
    }

    public void AnimInOut()
    {
        animator.ResetTrigger("in");
        animator.SetTrigger("out");
    }

    public bool getIsKeyboard()
    {
        return isKeyboard;
    }
}


