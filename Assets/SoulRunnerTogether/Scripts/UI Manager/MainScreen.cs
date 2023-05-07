using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreen : MonoBehaviour
{
    private bool enter = false;
    public float nbSecondesIntro = 10f;
    void Start()
    {
        if (enter == false)
            StartCoroutine(your_timer());
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator your_timer()
    {
        enter = true;
        yield return new WaitForSeconds(0.1f);
        enter = false;
        Destroy(gameObject);
    }
}
