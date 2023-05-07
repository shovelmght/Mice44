using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFaceCam : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cam.transform);
        transform.Rotate(new Vector3(0f, 180f, 0f));
    }
}
