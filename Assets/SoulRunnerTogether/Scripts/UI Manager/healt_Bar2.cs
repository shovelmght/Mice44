using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.Public;

public class healt_Bar2 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (PublicVariables.hp_player == 1)
        {
            Destroy(gameObject);
        }
    }
}
