using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer sprite;
    [SerializeField]
    protected GameObject prefabSmoke;
    public float delayFlash;
    public int delayRed;
    public int life;
    private bool canDamage = true;

    public void DamageShield()
    {
        if(canDamage)
        {
            StartCoroutine(FlashingRed());
        }
    }

    public int GetLife()
    {
        return life;
    }

    public void ActiveShield()
    {
        sprite.enabled = true;
    }
    IEnumerator FlashingRed()
    {
        life -= 1;
        if (life < 1)
        {
            sprite.enabled = false;
            Instantiate(prefabSmoke, transform.position, Quaternion.identity);
        }
        canDamage = false;
        for (int i = 0; i < delayRed; i++)
        {
            sprite.color = new Color(1.0f, 0.0f, 0.0f, 0.4f);
            yield return new WaitForSeconds(delayFlash);
            sprite.color = new Color(1.0f, 1.0f, 1.0f, 0.4f);
            yield return new WaitForSeconds(delayFlash);
        }
        canDamage = true;
    }
}
