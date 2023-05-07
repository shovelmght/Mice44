using UnityEngine;

public class BlockClimb : MonoBehaviour
{
    private Player player;
    private bool isFall = false;
    // Start is called before the first frame update

    private void Update()
    {
        if (isFall)
        {
            if(player != null)
            {
                player.ReturnToWalkMode();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        player = other.gameObject.GetComponent<Player>();
        isFall = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isFall = false;
    }
}
