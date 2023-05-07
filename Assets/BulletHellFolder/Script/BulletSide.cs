using UnityEngine;

public class BulletSide : Bullet
{
    public bool isrightSide = false;
    // Start is called before the first frame update
    override public void Start()
    {
        float randFlt = Random.Range(10.5f, 38.5f);
        Destroy(gameObject, timeLife);
        if(isrightSide)
        {
            transform.Rotate(0, 0, randFlt);
            shootDir = new Vector3(-randFlt / 100, 1, 0);
        }
        else
        {
            transform.Rotate(0, 0, -randFlt);
            shootDir = new Vector3(randFlt / 100, 1, 0);
        }

    }

    public void SetBulletIsRight()
    {
        isrightSide = true;
    }
}
