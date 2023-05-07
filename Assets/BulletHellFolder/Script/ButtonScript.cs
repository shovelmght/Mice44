using UnityEngine;


public class ButtonScript : MonoBehaviour
{
    public SpriteRenderer frame;
    // Start is called before the first frame update
    void Start()
    {
        frame = GetComponent<SpriteRenderer>();
        //frame.color = new Color(.65f, .46f, .46f);
    }

    public void OnEnterUI()
    {
        frame.color = new Color(.65f, .46f, .46f);
    }
    public void OnEXitUI()
    {
        frame.color = new Color(255, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
