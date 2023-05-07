using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigShip : Ennemy
{
    private float rotationShip = 3;
    public float angle = 2.5f;
    public float SpeedRot = 2.5f;
    protected bool right = true;
    public override void Start()
    {
        speed = Random.Range(minRangeSpeed, maxRangeSpeed);
        stateShip = StateShip.Move;
        rz = (Random.Range(-108f, -109.1f));
        canon1.transform.rotation = Quaternion.EulerAngles(0, 0, rz);
        canon2.transform.rotation = Quaternion.EulerAngles(0, rot, rz);
        if (Random.value < .5)
        {
            angle = -1.5f;
        }
        else
        {
            angle = 2.5f; 
        }
        SpeedRot = Random.Range(0.5f, 4.6f);
    }

    override public void Update() 
    {
        switch (stateShip)
        {
 
            case StateShip.Move:
                if (rotationShip > angle)
                {
                    right = false;
                }
                else if (rotationShip < -angle)
                {
                    right = true;
                }
                if (right)
                {
                    rotationShip += SpeedRot * Time.deltaTime;
                }
                else
                {
                    rotationShip -= SpeedRot * Time.deltaTime;
                }
                transform.Rotate(0, 0, rotationShip, Space.Self);

                vecDir = noseShip.transform.position - transform.position;
                transform.position += vecDir * speed * Time.deltaTime;
                transform.position += Vector3.down * speed/2 * Time.deltaTime;
                transform.position += Vector3.down * speed * Time.deltaTime;
                //canon2.transform.rotation = Quaternion.EulerAngles(0, rot, rz);

                break;
            case StateShip.Hit:
                break;
            case StateShip.Fall:
                transform.Rotate(0, 0, rot*2, Space.Self);

                vecDir = noseShip.transform.position - transform.position;
                transform.position += Vector3.down * speed * Time.deltaTime;
                canon2.transform.rotation = Quaternion.EulerAngles(0, rot, rz);
                break;
        }

    }

    override public IEnumerator FlashingRed()
    {
        speed = Random.Range(1.5f, 2.5f);
        for (int i = 0; i < delayRed; i++)
        {

            sprite.color = Color.red;
            yield return new WaitForSeconds(flashingRate);
            sprite.color = Color.white;
            yield return new WaitForSeconds(flashingRate);
        }
        canTakeDamage = true;
    }
}
