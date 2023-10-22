using UnityEngine;

//this class causes objects 
//to cap forward and backward
public class WallCube : MonoBehaviour
{
    public float maxDistance = 0.25f;
    public float maxSpeed = 0.4f;
    public float minSpeed = 0.04f;
    private bool reverseTranslation = false;
    private float speedTranslation;

    void Start()
    {
        speedTranslation = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.z > maxDistance)
        {
            reverseTranslation = false;
        }
        else if (transform.localPosition.z < -maxDistance)
        {
            reverseTranslation = true;
        }

        if (reverseTranslation)
        {
            transform.localPosition += (Vector3.forward * speedTranslation * Time.deltaTime);

        }
        else
        {
            transform.localPosition += (-Vector3.forward * speedTranslation * Time.deltaTime);
        }
    }
}
