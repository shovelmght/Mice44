using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerU : MonoBehaviour
{
    public bool isHeart;
    public AudioSource sound;
    private bool doOnce = true;
    [SerializeField]
    private SpriteRenderer sprite;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(doOnce)
            {
                doOnce = false;
                sprite.enabled = false;
                sound.Play();
                if(isHeart)
                {
                    collision.gameObject.GetComponent<PlanePlayer>().RestoreLife();
                }
                else
                {
                    collision.gameObject.GetComponent<PlanePlayer>().SetEnumPower(true);
                }
               
                Destroy(this.gameObject, 0.5f);
            }

        }
    }
}
