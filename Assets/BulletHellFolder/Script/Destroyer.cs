using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float delayToDestory;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, delayToDestory);
    }
}
