using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.Player;
using LesserKnown.Public;
using LesserKnown.AI;
using LesserKnown.Camera;
using SpriteGlow;
using LesserKnown.Audio;

public class MergePlayer : MonoBehaviour
{
    public CharacterController2D player1;
    public CharacterController2D player22;
    public GameObject player2;
    public GameObject boss;
    public BossControl bossScript;
    public GameObject spawnToBoss;
    public GameObject mergeFX;
    public bool is_merged = false;
    public CameraFollow camBoss;
    public CameraFollow camNiveau;
    public int layerPlayer = 6;
    public AudioManager audioManager;
    private int max = PublicVariables.MAX_COLLECTIBLES;
    public float vitesseMerge =1;
    public float tempsMerge;
    public float maxAlphaGlow = 38f;
    public float minAlphaGlow = 255f;
    private SpriteGlowEffect glowMerge;
    void Start()
    {
       // camBoss.enabled = false;
        boss.SetActive(false);
        bossScript = boss.GetComponent<BossControl>();
        spawnToBoss.SetActive(false);
        glowMerge = player1.GetComponent<SpriteGlowEffect>();
    }

    void Update()
    {
        if (!is_merged)
        {
            if (PublicVariables.APPLES == max && PublicVariables.COINS == max)
            {
                player1.DonTMovePlsDuringFusion();
                player22.DonTMovePlsDuringFusion();
                is_merged = true;
                StartCoroutine("TeleportToBossIE");
            }
        }

        //POUR TESTS DE LAYER
        if (is_merged)
        {
            player1.setLayerController(layerPlayer);

        }
        tempsMerge = vitesseMerge * Time.deltaTime;

    }

    private IEnumerator TeleportToBossIE()
    {
        yield return new WaitForSeconds(1.0f);

        //+anim teleportation ??
        //player teleport to their position on the boss plateform
        spawnToBoss.SetActive(true);
        float x = spawnToBoss.transform.position.x;
        float y = spawnToBoss.transform.position.y;
        float z = spawnToBoss.transform.position.z;
        //Debug.Log("X " + x);
        player1.transform.position = new Vector3(x-1,y,z);
        player22.transform.position = new Vector3(x+1,y,z);

        yield return new WaitForSeconds(0.5f);

        PublicVariables.IS_FUSIONED = true; 
        player1.is_active = true;

        //pour setter le layer du player a Terrain #3 pour pouvoir "voler" ...
        player1.setLayerController(layerPlayer);

        StartCoroutine("MergeSequenceIE");
    }

    private IEnumerator MergeSequenceIE()
    {
       

        yield return new WaitForSeconds(0.5f);

        mergeFX.SetActive(true); //FX Particules Merge light ON

        //amene les 2 players a la meme position --- TEST LERP POUR + SMOOTH MARCHE PAS comme je veux??
        player1.transform.position = spawnToBoss.transform.position;
        player22.transform.position = spawnToBoss.transform.position;
        //Change the glow
        StartCoroutine("FadeglowIE");

        //desactive player 2
        player2.SetActive(false);

        //yield return new WaitForSeconds(.5f);

        //PLayer Devient plus gros !!!  Ca BUG la life bar ...
        //player1.transform.localScale = new Vector3(1.5f,1.5f,0);

        //Enable the LIFEBAR
        player1.lifeBar.SetActive(true);

        spawnToBoss.SetActive(false);//deactive all. FX too

        yield return new WaitForSeconds(.2f);

        //SWAP CAMERA SIZE & position... to be fine tuned
        //camNiveau.Set_Camera_Boss(player1.transform);
        Debug.Log("SwapCamewra-1");
        yield return new WaitForSeconds(1f);
        StartCoroutine(audioManager.FadeOut());
        camNiveau.gameObject.GetComponent<Camera>().enabled = false;

        camBoss.gameObject.SetActive(true);
        camBoss.Set_Camera_Local(player1.transform);

        //NOW FIGHT THE BOSS ..
        BossAppear();
    }

    private void BossAppear()
    {
        boss.SetActive(true);

    }

    private IEnumerator FadeglowIE() 
    {
        glowMerge.enabled = true;

        //Color oldCol = glowMerge.GlowColor;
        glowMerge.GlowColor = Color.cyan; //cyan = 0 1 1 1 
        //Debug.Log("nice cyan value"+glowMerge.GlowColor);
        yield return new WaitForSeconds(0.05f);

        glowMerge.GlowColor = new Color(0, 98, 191, 103);
       // Debug.Log("intense cyan value" + glowMerge.GlowColor);

        yield return new WaitForSeconds(0.1f);

        //glowMerge.GlowColor = oldCol;
        glowMerge.GlowColor = Color.cyan; //cyan

        yield return new WaitForSeconds(0.1f);
    }
}

//void Update()
//{
//    if (Time.time > done)
//    {
//        done = Time.time + timeToWait;
//        doSomething();
//    }
//}

