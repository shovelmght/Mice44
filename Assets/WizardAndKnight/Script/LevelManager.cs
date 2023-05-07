using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public GameObject Wizard;
    public GameObject Gladiator;
    public GameObject grockLOrk;     // ref to ennemy of instantiate
    public GameObject player;     // ref to ennemy of instantiate

    public CameraWizard cam;                    // ref to black screen transition
    public GrockLork grock;                    // ref to black screen transition
    public CaveTeleport[] cave;                    // ref to black screen transition
    public ChestOpener chest;                    // ref to black screen transition




    public FadeWizardAndKnight ScreenVictory;                    // ref to black screen transition
    public FadeWizardAndKnight ScreenLoose;                    // ref to black screen transition

    public GameObject screenLooseObj;      //ref to position of respawn point
    public GameObject screenWinObj;      //ref to position of respawn point

    private GameObject[] worldA;    // ref to collider 2d side A
    private GameObject[] worldB;    // ref to collider 2d side B
    private GameObject[] worldC;    // ref to collider 2d side C
    private GameObject[] ennemyA;    // ref to ennemies side A
    private GameObject[] ennemyB;         // ref to ennemies side B
    private GameObject[] ennemy_A_Hard;    // ref to ennemies side A
    private GameObject[] ennemy_B_Hard;         // ref to ennemies side B
    private GameObject[] ennemyC;    // ref to ennemies side C
    private GameObject[] ennemy_C_Hard;    // ref to ennemies side C
    private GameObject[] ennemyWorld;       // ref to all ennemie in world
    private GameObject[] trigger;          // ref of all trigger of ennemies
    public GameObject respointPoint;      //ref to position of respawn point

    [SerializeField]
    private float DelayRespawn = 3;       // end of delay
    private float current_delay;         // delay for restpawns player


    private bool doOnce;                // make call couroutine do once
    private bool respawnBeginning;    // activate respawn event
    [SerializeField]
    private int sideWorld = 1;



    // Start is called before the first frame update
    void Start()
    {
        GameManagerWizardAndKnight.instance.SetLifeBarInvisible(false);
        Cursor.lockState = CursorLockMode.Locked;
        //LocaleDropdown.dr

        respointPoint = GameObject.Find("SpawnPoint");     // get transform of position spawn player

        if (GameManagerWizardAndKnight.instance.GetterIsKnight())
        {
            player = Instantiate(Gladiator, respointPoint.transform.position, Quaternion.Euler(0, 180, 0));     // Instantiate projectil
        }
        else
        {
            player = Instantiate(Wizard, respointPoint.transform.position, Quaternion.Euler(0, 180, 0));   // Instantiate projectil
         
        }
        

        worldA = GameObject.FindGameObjectsWithTag("WorldA");        // fill collider 2d side A array with tag
        ennemyA = GameObject.FindGameObjectsWithTag("EnnemyA");        // fill ennemies side A array with tag
        ennemy_A_Hard = GameObject.FindGameObjectsWithTag("EnnemyAHard");        // fill ennemies side A array with tag
        worldB = GameObject.FindGameObjectsWithTag("WorldB");      // fill collider 2d side B array with tag
        ennemyB = GameObject.FindGameObjectsWithTag("EnnemyB");      // fill ennemies side B array with tag
        ennemy_B_Hard = GameObject.FindGameObjectsWithTag("EnnemyBHard");      // fill ennemies side B array with tag
        worldC = GameObject.FindGameObjectsWithTag("WorldC");      // fill collider 2d side B array with tag
        ennemyC = GameObject.FindGameObjectsWithTag("EnnemyC");      // fill ennemies side B array with tag
        ennemy_C_Hard = GameObject.FindGameObjectsWithTag("EnnemyCHard");      // fill ennemies side B array with tag


        screenLooseObj = GameObject.FindGameObjectWithTag("FadeLoose");      // fill ennemies side B array with tag
        screenWinObj = GameObject.FindGameObjectWithTag("FadeWin");      // fill ennemies side B array with tag
        ScreenVictory = screenWinObj.GetComponent<FadeWizardAndKnight>();    // get fade Win UI scrren
        ScreenLoose = screenLooseObj.GetComponent<FadeWizardAndKnight>();    // get fade Loose UI scrren


        cam = GameObject.FindObjectOfType<CameraWizard>();     // get fade Loose image scrren
        grock = GameObject.FindObjectOfType<GrockLork>();     // get fade Loose image scrren
        cave = CaveTeleport.FindObjectsOfType<CaveTeleport>();     // get fade Loose image scrren

        chest = ChestOpener.FindObjectOfType<ChestOpener>();     // get fade Loose image scrren


        DestroyAllEnnemy();       //Destroy all ennemy & trigger
        SetWorldSide_1();         // active collider 2d world and instatiate ennemies

        //Tell set correct player ref
        cam.SetCameraFollow();      //Tell set correct player ref to Vcam


        chest.SetPlayerRef();       //Tell set correct player ref to Chest

        for (int i = 0; i < cave.Length; i++)
        {
            cave[i].SetPlayerRef();
        }
     
    }



    // Update is called once per frame
    void Update()
    {
    
        //Event respawn button
        if (respawnBeginning)
        {
            if (!doOnce)
            {

                GameManagerWizardAndKnight.instance.CallFade(true);     // fade screen to black
            }

            doOnce = true;

            if (current_delay >= DelayRespawn)
            {
                DestroyAllEnnemy();       //Destroy all ennemy & trigger
                SetWorldSide_1();        // active collider 2d world and instatiate ennemies
                TeleportPlayerSpawn();     //Teleport player to beginning level

                current_delay = 0;      // reset delay
                respawnBeginning = false;   // rester bool for next time
                doOnce = false;
            }
            current_delay += Time.deltaTime;   //add time
        }
    }


    //setter bool who active respawn player whith input button
    public void SetRespawnBeginning(bool onOff)
    {
        respawnBeginning = onOff;
    }


    //Change level when player is dead or win
    public IEnumerator ChangeLvl (bool isWin)
    {

        if(isWin)
        {
            StartCoroutine(ScreenVictory.Lerp(true));     // fade screen to black
        }
        else
        {
            StartCoroutine(ScreenLoose.Lerp(true));     // fade screen Loose to black
        }

        yield return new WaitForSeconds(2);

        GameManagerWizardAndKnight.instance.CallFade(false);    //fade to black
        GameManagerWizardAndKnight.instance.SetLifeBarInvisible(true);

        yield return new WaitForSeconds(3);

        if (isWin)
            GameManagerWizardAndKnight.instance.SetterUnlockLvl();    // Unlock next level il the player win

        if (GameManagerWizardAndKnight.instance.GetterCurrentLvl() == 1)     // check what level is right now
        {
            StartCoroutine(LoadingScene.LoadYourAsyncScene("MenuScene", "Level_1"));     // Unload current scene and load chosen level
        }
        else if (GameManagerWizardAndKnight.instance.GetterCurrentLvl() == 2)    // check what level is right now
        {
            StartCoroutine(LoadingScene.LoadYourAsyncScene("MenuScene", "Level_2"));        // Unload current scene and load chosen level
        }
        else if (GameManagerWizardAndKnight.instance.GetterCurrentLvl() == 3)    // check what level is right now
        {
            StartCoroutine(LoadingScene.LoadYourAsyncScene("MenuScene", "Level_3"));         // Unload current scene and load chosen level
        }
    }


    // event enter cave
    public void EnterCave()
    {
        switch (sideWorld)
        {
            case 1:
                SetWorldSide_1();
                break;
            case 2:
                SetWorldSide_2();
                break;
            case 3:
                SetWorldSide_3();
                break;
            case 4:
                SetWorldSide_1();
                break;
            default:
                break;
        }
    }



    // restart level
    public IEnumerator RestartLevel()
    {

        GameManagerWizardAndKnight.instance.CallFade(true);     // fade screen to black

        yield return new WaitForSeconds(3);
        TeleportPlayerSpawn();     //Teleport player to beginning level
        DestroyAllEnnemy();       //Destroy all ennemy & trigger
        SetWorldSide_1();         // active collider 2d world and instatiate ennemies
    }


    //Destroy all ennemy & trigger
    private void DestroyAllEnnemy()
    {
        // destroy all ennemies
        ennemyWorld = GameObject.FindGameObjectsWithTag("Ennemy");  //  full array of all ennemies in world
        for (int i = 0; i < ennemyWorld.Length; i++)
        {
            Destroy(ennemyWorld[i]);  //  destroy  all ennemies in world
        }

        // destory all trigger of ennemies
        trigger = GameObject.FindGameObjectsWithTag("Trigger");  //  full array of all trigger in world
        for (int i = 0; i < trigger.Length; i++)
        {
            Destroy(trigger[i]);   //  destroy  all ennemies trigger in world
        }

    }


    // active collider 2d world A and instatiate ennemies side A
    public void SetWorldSide_1()
    {
        DestroyAllEnnemy();
        //instantiate more ennemies side A if hard difficulty is set
        if (GameManagerWizardAndKnight.instance.GetterHardDifficulty())   // check if the difficulty is set to hard
        {
            //instantiate all ennemies side A
            for (int i = 0; i < ennemy_A_Hard.Length; i++)
            {
                Instantiate(grockLOrk, ennemy_A_Hard[i].transform.position, Quaternion.identity);

            }
        }

        //instantiate all ennemies side A
        for (int i = 0; i < ennemyA.Length; i++)
        {
           Instantiate(grockLOrk, ennemyA[i].transform.position, Quaternion.identity);

        }
     

        //desactive all collider 2d side B
        for (int i = 0; i < worldB.Length; i++)
        {
            worldB[i].SetActive(false);
        }

        //active all collider 2d side A 
        for (int i = 0; i < worldA.Length; i++)
        {

            worldA[i].SetActive(true);
        }
        //Set active all collider 2d side B
        for (int i = 0; i < worldC.Length; i++)
        {
            worldC[i].SetActive(false);
        }



    }


    // active collider 2d world B and instatiate ennemies side B
    void SetWorldSide_2()
    {
        DestroyAllEnnemy();
        //instantiate more ennemies side A if hard difficulty is set
        if (GameManagerWizardAndKnight.instance.GetterHardDifficulty())   // check if the difficulty is set to hard
        {
            //instantiate all ennemies side B
            for (int i = 0; i < ennemy_B_Hard.Length; i++)
            {
                Instantiate(grockLOrk, ennemy_B_Hard[i].transform.position, Quaternion.identity);
            }
        }

        //instantiate all ennemies side B
        for (int i = 0; i < ennemyB.Length; i++)
        {
            Instantiate(grockLOrk, ennemyB[i].transform.position, Quaternion.identity);
        }
        

        // desactive all collider 2d side A       
        for (int i = 0; i < worldA.Length; i++)
        {
            worldA[i].SetActive(false);
        }
        // desactive all collider 2d side A       
        for (int i = 0; i < worldC.Length; i++)
        {
            worldC[i].SetActive(false);
        }

        //Set active all collider 2d side B
        for (int i = 0; i < worldB.Length; i++)
        {
            worldB[i].SetActive(true);
        }


    }

    // active collider 2d world C and instatiate ennemies side C
    void SetWorldSide_3()
    {
        DestroyAllEnnemy();
        //instantiate more ennemies side A if hard difficulty is set
        if (GameManagerWizardAndKnight.instance.GetterHardDifficulty())   // check if the difficulty is set to hard
        {
            //instantiate all ennemies side B
            for (int i = 0; i < ennemy_C_Hard.Length; i++)
            {
                Instantiate(grockLOrk, ennemy_C_Hard[i].transform.position, Quaternion.identity);
            }
        }

        //instantiate all ennemies side B
        for (int i = 0; i < ennemyC.Length; i++)
        {
            Instantiate(grockLOrk, ennemyC[i].transform.position, Quaternion.identity);
        }


        // desactive all collider 2d side A       
        for (int i = 0; i < worldB.Length; i++)
        {
            worldB[i].SetActive(false);
        }

        //Set active all collider 2d side B
        for (int i = 0; i < worldC.Length; i++)
        {
            worldC[i].SetActive(true);
        }


    }


    //Teleport player to beginning level
    private void TeleportPlayerSpawn()
    {
        player.transform.position = respointPoint.transform.position;
        player.transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    public void SetterSideWorld(int nbr)
    {

        sideWorld += nbr;
    }
}




