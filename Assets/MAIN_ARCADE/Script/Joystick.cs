using UnityEngine;
public class Joystick : MonoBehaviour
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

    public void SpawnCancas()
    {
        canvas.SetActive(true);
        lightSpot.GetComponent<Light>().color = Color.blue;
        soundInteraction.pitch = 1.3f;
        soundInteraction.volume = 0.25f;
        soundInteraction.Play();
    }
    public void DestroyCancas()
    {
        canvas.SetActive(false);
        lightSpot.GetComponent<Light>().color = Color.red;
        soundInteraction.pitch = 2.3f;
        soundInteraction.volume = 0.1f;
        soundInteraction.Play();
    }

    public void PlayArcade()
    {
        camArcade.SetActive(true);
        if(sceneString != "Main Scene")
        videoChanger.ChangeVideo();
        DestroyCancas();
        StartCoroutine(sceneChanger.ChangeScene(sceneString));
    }
}
