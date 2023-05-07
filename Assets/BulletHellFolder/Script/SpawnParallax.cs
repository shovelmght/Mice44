using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParallax : MonoBehaviour
{
    [SerializeField]
    private int timeToSpawn;
    [SerializeField]
    private GameObject parallax;
    [SerializeField]
    private GameObject cloud;
    [SerializeField]
    private GameObject[] posCloud;
    public List<SpriteRenderer> paralaxes = new List<SpriteRenderer>();
    public List<SpriteRenderer> allClouds = new List<SpriteRenderer>();

    // Start is called before the first frame update
    void Start()
    {
        var tempParalax = Instantiate(parallax, transform);
        paralaxes.Add(tempParalax.GetComponent<SpriteRenderer>());
        StartCoroutine(delaySpawn());
        StartCoroutine(delaySpawnCloud());
    }


    IEnumerator delaySpawn()
    {
        yield return new WaitForSeconds(timeToSpawn);
        var tempParalax = Instantiate(parallax, transform);
        Debug.Log("add");
        paralaxes.Add(tempParalax.GetComponent<SpriteRenderer>());
        StartCoroutine(delaySpawn());
    }
    IEnumerator delaySpawnCloud()
    {
        yield return new WaitForSeconds(timeToSpawn / 3);
        int rndInt = Random.Range(0, posCloud.Length);
        var tempCloud = Instantiate(cloud, posCloud[rndInt].transform.position + new Vector3(5,0,0), Quaternion.identity);
        allClouds.Add(tempCloud.GetComponent<SpriteRenderer>());
        StartCoroutine(delaySpawnCloud());
    }

    public void ChangeColor()
    {
        for (int i = 0; i < paralaxes.Count; i++)
        {
            if(paralaxes[i] != null)
            {
                paralaxes[i].color = Color.gray;
            }
        }
        for (int i = 0; i < allClouds.Count; i++)
        {
            if (allClouds[i] != null)
            {
                allClouds[i].color = Color.gray;
            }
        }
    }

    public void RestaureColor()
    {
        for (int i = 0; i < paralaxes.Count; i++)
        {
            if (paralaxes[i] != null)
            {
                paralaxes[i].color = Color.white;
            }
        }
        for (int i = 0; i < allClouds.Count; i++)
        {
            if (allClouds[i] != null)
            {
                allClouds[i].color = Color.white;
            }
        }
    }


}
