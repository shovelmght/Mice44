using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{

    Rigidbody rigidbody;
    //[SerializeField] Camera mainCamera;
    [SerializeField] Transform shootingPos;
    [SerializeField] AudioSource audioSource;
    NewActionInputManager playerInput;

    public GameObject laser;
    Camera mainCamera;
    [SerializeField] float movingForce = 10f;
    [SerializeField] float shootingForce = 10f;

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

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        playerInput.Asteroid.Fire.performed += _ => Fire();
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    void Update()
    {
        var mymaincam = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mymaincam.y = -3f;
        var direction = mymaincam - transform.position;
        var angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(90f, 0f, -angle);
    }

    private void FixedUpdate()
    {
        Vector2 movementInput = playerInput.Asteroid.Movement.ReadValue<Vector2>();
        rigidbody.AddForce(new Vector3(movementInput.x, 0f, movementInput.y) * movingForce);
    }

    void Fire()
    {
        audioSource.Play();
        var laserShoot = Instantiate(laser, shootingPos.position, Quaternion.identity);
        laserShoot.GetComponent<Rigidbody>().AddForce(transform.up * shootingForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (GameObject.FindObjectOfType<Gamemanager>().IsInGame())
        {
            if (collision.gameObject.tag == "Enemy")
            {
                GameObject.FindObjectOfType<Gamemanager>().ChangeStateToDead();
                Destroy(this.gameObject);
            }
        }
    }
}
