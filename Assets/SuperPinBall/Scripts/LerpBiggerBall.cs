using UnityEngine;

public class LerpBiggerBall : MonoBehaviour
{
    public float SpeedScale = 1;
    private float maxScale = 2.5f;


    void Update()
    {
        if(transform.localScale.x < maxScale)
        {
            transform.localScale = new Vector3(transform.localScale.x + SpeedScale * Time.deltaTime, transform.localScale.y + SpeedScale * Time.deltaTime, transform.localScale.z + SpeedScale * Time.deltaTime);
        }
    }

    public void SetScale(float newScale)
    {
        transform.localScale = new Vector3(newScale, newScale, newScale);
    }
}
