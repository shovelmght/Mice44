using System.Collections;
using UnityEngine;

public class CannonEnnemy : BulletEnnemy
{
    public GameObject EndCanonDir;
    public GameObject EndCanonPos;
    public GameObject bullet;
    [SerializeField]
    private float fireRate;
    public float speedBulletBigShip = 20f;
    public bool isBigShip = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delaySpawnBullet());
    }

    IEnumerator delaySpawnBullet()
    {
        yield return new WaitForSeconds(fireRate);
        var shell = Instantiate(bullet, EndCanonPos.transform.position, transform.rotation);
        shell.GetComponent<BulletEnnemy>().shootDir = EndCanonDir.transform.position -  transform.position;
        if(isBigShip)
        {
           shell.GetComponent<BulletEnnemy>().speed = speedBulletBigShip;
        }
       
        StartCoroutine(delaySpawnBullet());
    }
}
