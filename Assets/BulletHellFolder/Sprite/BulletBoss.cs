using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBoss : Bullet
{
    virtual public void Update()
    {
        transform.position += shootDir * speed * Time.deltaTime;
    }
}
