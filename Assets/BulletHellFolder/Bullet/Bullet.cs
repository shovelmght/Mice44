using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float timeLife;
    public Vector3 shootDir;
    // Start is called before the first frame update
    virtual public void Start()
    {
        Destroy(gameObject, timeLife);
    }

    // Update is called once per frame
    virtual public void Update()
    {
        transform.position += shootDir * speed * Time.deltaTime;
    }
}
