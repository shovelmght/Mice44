using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private bool moveUp = false;
    public float minPosz = 25.39f;
    public float maxPosz = 31.36f;
    public float speed = 2;
    private bool starTimerUp = false;
    public float timer = 0;
    public float endTimer = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(starTimerUp)
        {
            if (timer > endTimer)
            {
                timer = 0;
                starTimerUp = false;
                moveUp = true;
            }
            timer += Time.deltaTime;
        }


        if(moveUp)
        {

            if(transform.position.z > minPosz)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z - speed * Time.deltaTime); 
            }
            else
            {
                    
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            starTimerUp = true;
        }
    }
}

