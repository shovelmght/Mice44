using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteEffect : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, .9f);      // destroy this game object
    }

}
