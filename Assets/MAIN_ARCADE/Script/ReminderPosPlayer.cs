using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReminderPosPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    public GameObject playerRef;
    public static ReminderPosPlayer instance;
    public ReminderPosPlayer otherReminderPosPlayer;
    public  Vector3 playerPos;
    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        MakeSingleton();
    }
    private void Start()
    {
        playerRef = Instantiate(player, playerPos, Quaternion.identity);
    }
    public ReminderPosPlayer MakeSingleton()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            otherReminderPosPlayer = GameObject.FindGameObjectWithTag("Reminder").GetComponent<ReminderPosPlayer>();
            otherReminderPosPlayer.SetPositionPlayer();
            Destroy(this.gameObject);
        }

        return instance;
    }
    public void GetPositionPlayer()
    {
        playerPos = playerRef.transform.position;
    }

    public void SetPositionPlayer()
    {
        playerRef = Instantiate(player, playerPos, Quaternion.identity);

    }


}
