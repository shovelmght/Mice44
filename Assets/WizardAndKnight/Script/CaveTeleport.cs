using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveTeleport : MonoBehaviour
{
    [SerializeField]
    private LevelManager levelManger;    // ref to Game Manager
    [SerializeField]
    private Transform CaveB;
    [SerializeField]
    private bool isCaveB;
    [SerializeField]
    private PlayerController player;     // ref to player

    private AnimationUi_W uI;    // ref to UI 'W' key
    private SpriteRenderer sR;     //red to SpriteRenderer of UI 'W'

    public bool canEntercave;
    private bool playerisThere;

    private bool doOnce;


    private void Start()
    {
        levelManger = GameObject.FindObjectOfType<LevelManager>();   // Get LevelManager Ref

        uI = transform.GetChild(0).GetComponent<AnimationUi_W>();    // get child component UI
        sR = uI.GetComponent<SpriteRenderer>();     // get component SpriteRenderer of UI

        sR.enabled = false;           // Make UI invisible
    }

    void Update()
    {
        if(playerisThere)
        {

            if (player.GetinputEntercave() && canEntercave && !doOnce)
            {

                doOnce = true;
                StartCoroutine(TeleportPlayer());
            }  
        }
    }

        //Get Ref player after he was instantiate
        public void SetPlayerRef()
    {
        player = FindObjectOfType<PlayerController>();      // Get player Ref
        playerisThere = true;
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Player")
        {
   
            sR.enabled = true;          // Make UI visible
            canEntercave = true;     //  allow thee player to press 'W' key

        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Player")
        {

            sR.enabled = false;          // Make UI invisible
            canEntercave = false;     // Not allow thee player to press 'W' key

        }
    }



    IEnumerator TeleportPlayer()
    {
        if (isCaveB)
            levelManger.SetterSideWorld(-1);
        else
            levelManger.SetterSideWorld(1);
        levelManger.EnterCave();          //Set ennemy and floor active on side B
        StartCoroutine(uI.Lerp());      //Make animation of UI
        player.SetterIsInvulnerable(true);
        player.SetterDisableInput(true);          // disable imput while teleport cave

        yield return new WaitForSeconds(0.5f);


        Quaternion tempsRot = player.transform.localRotation;   // its a temps variable for after teleportation
        player.SetterRotate(true);

        GameManagerWizardAndKnight.instance.CallFade(true);


        yield return new WaitForSeconds(2);

        player.SetterRotate(false);
        player.transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 90, 0), tempsRot, Time.time * 0.5f);    // rotate player to cave

        canEntercave = false;
        player.transform.position = CaveB.transform.position;


        player.SetterGravityNormal();    // return to gravity normal
        yield return new WaitForSeconds(1);


        player.SetterIsInvulnerable(false);
        player.SetterDisableInput(false);          // disable imput while teleport cave
        doOnce = false;
    }

}
