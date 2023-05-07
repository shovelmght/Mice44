using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBigger : MonoBehaviour
{
    private bool isBigger = true;
    private bool doOnceBigger = true;
    public float speedScale = 60;
    public float maxScale = 150;
    public float minScale = 50;

    void Update()
    {
        if (transform.localScale.x > maxScale && doOnceBigger)
        {
            doOnceBigger = false;
            isBigger = false;
        }
        else if (transform.localScale.x < minScale)
        {
            doOnceBigger = true;
            isBigger = true;
        }

        if(isBigger)
        {
            transform.localScale = new Vector3(transform.localScale.x + Time.deltaTime * speedScale, transform.localScale.y + Time.deltaTime * speedScale, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x - Time.deltaTime * speedScale, transform.localScale.y - Time.deltaTime * speedScale, transform.localScale.z);
        }
    }
}
