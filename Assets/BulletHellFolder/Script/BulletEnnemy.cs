using UnityEngine;

public class BulletEnnemy : MonoBehaviour
{

    public float scaleExplosion = 0.4f;
    public float speed;
    public float timeLife;
    public Vector3 shootDir;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeLife);
    }

    // Update is called once per frame
    virtual public void Update()
    {
        transform.localPosition += shootDir * speed * Time.deltaTime;
    }

    public void DestroyBullet()
    {

        Destroy(this.gameObject);
    }
}
