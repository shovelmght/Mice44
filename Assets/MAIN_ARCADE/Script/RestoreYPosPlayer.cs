using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestoreYPosPlayer : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter(Collider other)
    {
        GameObject player = other.gameObject;
        player.transform.position = (new Vector3(player.transform.position.x, 1, player.transform.position.z));
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }
}
