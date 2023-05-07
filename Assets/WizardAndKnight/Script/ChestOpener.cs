using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpener : MonoBehaviour
{
    private LevelManager levelManager;
    private PlayerController player;


    private AnimationUi_W uI;     // ref to UI 'W' key
    private SpriteRenderer sR;     //red to SpriteRenderer of UI 'W'

    private GameObject chestClose;    // ref to  close chest
    private GameObject chestOpen;    // ref to open chest



    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>(); // Get LevelManager Ref

        uI = transform.GetChild(0).GetComponent<AnimationUi_W>();     // get child component UI
        sR = uI.GetComponent<SpriteRenderer>();                  // get component SpriteRenderer of UI

        chestClose = this.gameObject.transform.GetChild(1).gameObject;            // get Game Object chest Close
        chestOpen = this.gameObject.transform.GetChild(2).gameObject;           // get Game Object chest open

        sR.enabled = false;           // Make UI 'W'invisible
        chestOpen.GetComponent<Renderer>().enabled = false;      // make chest invisible 

        player = FindObjectOfType<PlayerController>();       // Get player Ref
    }


    //Get Ref player after he was instantiate
    public void SetPlayerRef()
    {
        player = FindObjectOfType<PlayerController>();       // Get player Ref
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Player")
        {

            player.SetCanOpenChest(true);   // Allow thee player to press 'W' key for open chest
            sR.enabled = true;          // Make UI 'W visible

        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Player")
        {

            sR.enabled = false; ;          // Make UI invisible
            player.SetCanOpenChest(false);   // Now allow thee player to press 'W' key for open chest

        }
    }


    //Event Open chest
    public void OpenChest()
    {
        MusicManagerWizard.instance.FadeOut();
        StartCoroutine(uI.Lerp());         //Make animation of UI

        chestClose.GetComponent<Renderer>().enabled = false;      // make chest close invisible 
        chestOpen.GetComponent<Renderer>().enabled = true;      // make chest open visible 
        
        StartCoroutine(levelManager.ChangeLvl(true));     // fade screen to black

    }
}