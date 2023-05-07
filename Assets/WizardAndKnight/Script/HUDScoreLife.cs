using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScoreLife : MonoBehaviour
{
    [SerializeField]
    private bool isEnnemy;
    [SerializeField]
    private Image lifeBarBegin;
    [SerializeField]
    private Image lifeBar_1;
    [SerializeField]
    private Image lifeBar_2;
    [SerializeField]
    private Image lifeBar_3;
    [SerializeField]
    private Image lifeBarEnd;
    [SerializeField]
    private Image capsuleLifeBar;
    [SerializeField]
    private Text scoreTexte;              // ref to own

    


    void Start()
     {
        scoreTexte = GetComponentInChildren<Text>();           // get componant text
        capsuleLifeBar = GetComponent<Image>(); //get self componente capsule UI bar
        if(!isEnnemy)
        SetInvisible(true);
       
     }

    //Set UI life bar of hero
    public void SetLifeBar(int life)
    {
        
        if (life < 0)    //Check if life is below 0
            life = 0;    // if yes, li

        switch (life)
        {

            case 1:
                lifeBar_1.enabled = false;
                lifeBar_2.enabled = false;
                break;

            case 2:
                lifeBar_2.enabled = false;
                lifeBar_3.enabled = false;
                break;

            case 3:
                lifeBar_3.enabled = false;
                lifeBarEnd.enabled = false;
                break;

            case 4:
                lifeBarEnd.enabled = false;
                break;
            default:
                lifeBarBegin.enabled = false;
                lifeBar_1.enabled = false;
                break;

        }
    }

    //Made UI life bar invisible
    public void SetInvisible(bool onOff)
    {
        if(onOff)
        {
            lifeBarBegin.enabled = false;
            lifeBar_1.enabled = false;
            lifeBar_2.enabled = false;
            lifeBar_3.enabled = false;
            lifeBarEnd.enabled = false;
            capsuleLifeBar.color = new Color(0, 0, 0, 0);
        }
        else
        {
            lifeBarBegin.enabled = true;
            lifeBar_1.enabled = true;
            lifeBar_2.enabled = true;
            lifeBar_3.enabled = true;
            lifeBarEnd.enabled = true;
            capsuleLifeBar.color = new Color(1, 1, 1, 1); 
        }

    }

    //Set score text UI
    public void SetTexteScore(int score)
    {
        scoreTexte.text = " : " + score;  //put distance on texte
    }
}
