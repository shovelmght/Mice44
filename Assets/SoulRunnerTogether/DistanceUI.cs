using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceUI : MonoBehaviour
{
    private bool doOnce;

    private float startValue = 100;         // is the normal sise of texte
    private float endValue = 140;           // is the big size of texte when te player are far
    private float valueToLerp;              // is the value to lerp
    private int valuToLerpint;              // is for venvert valuetolerp to float in int
   
    [SerializeField]
    private float lerpDuration = 0.11f;        //time of lerp
    public Transform player1;               
    public Transform player2;
    public int maxDist;                     // max distance befor the text becom red
    [SerializeField]
    private Text distanceText;              // ref to own
    public float _Distance;                  // distance between players
    public float distance2;                 // for convert in positif
    public Text image;                      // ref to text   
    public RectTransform image2;            //ref to position
    

    private void Start()
    {
        //distance = ((player1.transform.position.x + player1.transform.position.y) - (player2.transform.position.x + player2.transform.position.y));  // calculate distance between player
        image = GetComponent<Text>();           // get componant text
        image2 = GetComponent<RectTransform>(); // get componant position

   

             StartCoroutine(Timer());           //call fonction timer
    }


    public IEnumerator Timer()
    {
        {
            
            _Distance= Vector3.Distance(player1.position, player2.position);

          
            // Display the distance in the UI text
            distanceText.text = "DIST : " + _Distance.ToString("F1");
            
            /*if (distance > 0)
            {
                distance = ((player1.transform.position.x + player1.transform.position.y) - (player2.transform.position.x + player2.transform.position.y));// calculate distance between player
                distanceText.text = "DIST : " + distance.ToString("F1");  //put distance on texte
                distance2 = distance - distance - distance;               //convert distance negatif to positif

            }
            else
            {

                distance = ((player1.transform.position.x + player1.transform.position.y) - (player2.transform.position.x + player2.transform.position.y));// calculate distance between player
                distance2 = distance - distance - distance;                 //convert distance negatif to positif
                distanceText.text = "DIST : " + distance2.ToString("F1");   // //put distance on texte
                
            }*/
        }
        if (_Distance > maxDist)
        {
            if(!doOnce)
            {
                StartCoroutine(Lerp());   // call fonction lerp do big text
                doOnce = true;
            }
   

            image.color = Color.red;   // change text color red

        }
        else
        {

            image.color = Color.green;   // change text color red
            doOnce = false;

        }
        yield return new WaitForSeconds(0.1f);   // delay
        StartCoroutine(Timer());                //call fonction timer 

    }

    IEnumerator Lerp()
    {
            //<----------------------------------------------Put sound here pls 


        float timeElapsed = 0;             // set timeElapse to 0
        while(timeElapsed <lerpDuration)  
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);   //lerp fonction
            timeElapsed += Time.deltaTime;   // The completion time in seconds since the last frame (Read Only).
            yield return null;    // idn what do that
            valuToLerpint = (int)valueToLerp;   // convert float to int
            image.fontSize = valuToLerpint;     // set text size
            image2.localPosition += Vector3.up; // set test postion


           
        
        }

        StartCoroutine(LerpRevert());     // call fonction revert for return size and position nomal


    }
    IEnumerator LerpRevert()
    {
        float timeElapsed = 0;
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(endValue, startValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;  // // The completion time in seconds since the last frame (Read Only).
            yield return null;  // idn what do that
            valuToLerpint = (int)valueToLerp;  // convert float to int
            image.fontSize = valuToLerpint;    // set text size back
            image2.localPosition += Vector3.down; // set test postion back


        }


    }
}
