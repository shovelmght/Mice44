using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField]
     private int speed;
    [SerializeField]
    private int timeDestroy;
    [SerializeField]
    private GameObject posNexParallax;
    [SerializeField]
    private GameObject[] posNexCloud;
    [SerializeField]
    private GameObject parallax;
    public bool isCloud;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, timeDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
    }

    public void SetPosNexParallax(GameObject _posNexParallax)
    {
        if(isCloud)
        {

        }
        posNexParallax = _posNexParallax;
    }

   
}
