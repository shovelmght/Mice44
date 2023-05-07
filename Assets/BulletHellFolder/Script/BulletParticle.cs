using UnityEngine;

public class BulletParticle : BulletEnnemy
{
    public float scale;
    public float zPosition = 0;
    public float speedScale;
    public bool isPowerUp2 = false;
    public bool scaleUP = true;

    public override void Update()
    {
        if(scale > 0.1f)
        {
            scaleUP = false;
        }
        if(scaleUP)
        {
            scale += speedScale * Time.deltaTime;
        }
        else
        {
            scale -= speedScale * Time.deltaTime;
        }
       
        if(!isPowerUp2)
        {
         
            transform.localPosition += shootDir * speed * Time.deltaTime;

        }
        transform.localScale = new Vector3(scale, scale, transform.localScale.z);
        transform.position = (new Vector3(transform.position.x, transform.position.y, zPosition));
    }
}
