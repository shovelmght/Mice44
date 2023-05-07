using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFireBall : MonoBehaviour
{
    public GameObject prefab;
    GameObject manager;
    public Vector3 fireballOffset = new Vector3(1, 0, 0);
    float spawnTimer = 0;
    public float spawnInterval = 2.0f;

    void Start()
    {
        manager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.GetComponent<GameManager>().GameState())
        {
            if (spawnTimer >= spawnInterval)
            {
                var fireBall = Instantiate(prefab, transform.position + fireballOffset, transform.rotation);
                fireBall.GetComponent<Rigidbody2D>().velocity += new Vector2(2,0);
                spawnTimer = 0;
            }
            else
            {
                spawnTimer += Time.deltaTime;
            }
        }
        else
        {
            spawnTimer = 0;
        }
    }
}
