using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.TrapsAndHelpers;

public class BoxControle2 : MonoBehaviour
{
    public BoxControl box;

    private Collider2D collidertd;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            box.ChangeLayer();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            box.ChangeLayerReverse();
        }
    }
}
