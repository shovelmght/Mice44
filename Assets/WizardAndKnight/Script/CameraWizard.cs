using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraWizard : MonoBehaviour
{
    private GameObject player;
    private CinemachineVirtualCamera vcam;


    //Find Player for Following Vcam
    public void SetCameraFollow()
    {
        var vcam = GetComponent<CinemachineVirtualCamera>();   // Get ref Vcam

        if (GameManagerWizardAndKnight.instance.GetterIsKnight())
        {
            player = GameObject.Find("KnightHeroPlayer(Clone)");     // Get Ref Gladiator
        }
        else
        {
            player = GameObject.Find("WizardHeroPlayer(Clone)");    // Get Ref Wizard

        }

        vcam.Follow = player.transform;  // Set Correct player to follow Vcam
    }


}
