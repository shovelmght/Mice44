using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;    // speed of object
    [SerializeField]
    private float timeDestroy = 1;    // speed of object


    private void Start()
    {
        Destroy(gameObject , timeDestroy);   //Destroy projectil after 1
    }
    // Update is called once per frame
    void Update()
    {

        transform.position -= transform.right * Time.deltaTime * speed;      // Move object forward him

    }

}
