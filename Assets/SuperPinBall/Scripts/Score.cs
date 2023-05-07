using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public PinBallGameManager gameManager;
    TextMesh txt;
    
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = gameManager.GetScore().ToString();
    }
}
