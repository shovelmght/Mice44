using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesSpawner : MonoBehaviour
{
    [SerializeField]
        private GameObject ships;
    [SerializeField]
    private GameObject[] spawnPoint;
    public float time = 2f;
    private int idx;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(time);
        idx = Random.Range(0, 15);
        Instantiate(ships, spawnPoint[idx].transform.position, Quaternion.identity);
        StartCoroutine(Spawn());
    }
}
