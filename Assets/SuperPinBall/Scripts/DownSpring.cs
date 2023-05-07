using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownSpring : MonoBehaviour
{
    [SerializeField] private AudioClip soundThrow;
    private AudioSource m_AudioSource;


    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.clip = soundThrow;
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            PlayAudio();
        }
    }

    public void SetScale(Vector3 newScale)
    {
        transform.localScale = newScale;
    }

    public void AjusteScale(float newScale)
    {
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + newScale * Time.deltaTime);
    }

    public Vector3 GetScale()
    {
        return transform.localScale;
    }

    private void PlayAudio()
    {
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
    }
}
