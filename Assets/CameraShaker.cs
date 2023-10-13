using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    public static CameraShaker Instance { get; private set; }
    [SerializeField] private  float shakeDuration = 0.5f;
    [SerializeField] private  float shakeAmount = 0.1f;
    [SerializeField] private  float decreaseFactor = 1.0f;
    [SerializeField] private Camera _Camera;
    private Vector3 originalPosition;
    // Start is called before the first frame update
    private void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [ContextMenu("Shake")]
    public void ShakeContextMenu()
    {
        StartCoroutine(Shake());
    }
    public IEnumerator Shake()
    {
        originalPosition = _Camera.transform.localPosition;
        float currentShakeDuration = shakeDuration;

        while (currentShakeDuration > 0)
        {
            // Move the camera randomly within a radius
            _Camera.transform.localPosition = originalPosition + Random.insideUnitSphere * shakeAmount;

            currentShakeDuration -= Time.deltaTime * decreaseFactor;

            yield return null;
        }

        // Reset the camera position when the shaking is done
        _Camera.transform.localPosition = originalPosition;
    }
}
