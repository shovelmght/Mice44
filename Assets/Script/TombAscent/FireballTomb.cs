using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballTomb : MonoBehaviour
{
    GameObject manager;
    Rigidbody2D self;

    void Start()
    {
        manager = GameObject.Find("GameManager");
        self = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!manager.GetComponent<GameManager>().GameState() || transform.position.y < -3.2)
        {
            Destroy(this.gameObject);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (self.velocity.y < -3)
        {
            self.velocity = new Vector2(self.velocity.y, 0);
        }
    }
}
