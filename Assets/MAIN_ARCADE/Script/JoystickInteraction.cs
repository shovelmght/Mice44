using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickInteraction : MonoBehaviour
{
    [SerializeField]
    private GameObject camArcade;
    [SerializeField]
    private VideoChanger videoChanger;
    [SerializeField]
    private GameObject canvas;
    [SerializeField]
    private GameObject lightSpot;
    [SerializeField]
    private SceneChanger sceneChanger;
    [SerializeField]
    private string sceneString;
    [SerializeField]
    private AudioSource soundInteraction;
    [SerializeField]
    private GameObject aButton;
    [SerializeField]
    private GameObject eKey;

    public void SpawnCancas(bool isKeyboard)
    {
        if(!isKeyboard)
        {
            aButton.SetActive(true);
        }
        else
        {
            eKey.SetActive(true);
        }
        canvas.SetActive(true);
        lightSpot.GetComponent<Light>().color = Color.blue;
        soundInteraction.pitch = 1.3f;
        soundInteraction.volume = 0.25f;
        soundInteraction.Play();
    }
    public void DestroyCancas()
    {

            aButton.SetActive(false);
            eKey.SetActive(false);
        
        canvas.SetActive(false);
        lightSpot.GetComponent<Light>().color = Color.red;
        soundInteraction.pitch = 2.3f;
        soundInteraction.volume = 0.1f;
        soundInteraction.Play();
    }

    public void PlayArcade()
    {
        camArcade.SetActive(true);
        if (sceneString == "SuperPinBallScene" || sceneString == "WizardAndKnightScene")
        {

        }
        else
        {
            videoChanger.ChangeVideo();
        }
        
        DestroyCancas();
        StartCoroutine(sceneChanger.ChangeScene(sceneString));
    }
}
