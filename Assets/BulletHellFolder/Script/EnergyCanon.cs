using System.Collections;
using UnityEngine;

public class EnergyCanon : MonoBehaviour
{
    public GameObject EndCanonDir;
    [SerializeField]
    public GameObject posCanon1;
    [SerializeField]
    public GameObject posCanon2;
    [SerializeField]
    public GameObject[] SpawnPos1;
    [SerializeField]
    public GameObject[] SpawnPos2;
    public GameObject bullet;
    [SerializeField]
    private float fireRate;
    private float posZParticle = -0.1f;
    public float endTime = 0.3f;
    public float lifeStimeBulle = 0.2f;
    public bool isBigShip = false; 
    private float timer = 0;

    private void Update()
    {
        if(timer > endTime)
        {
            timer = 0;
            int randIdx = Random.Range(0, 9);
            var shell = Instantiate(bullet,new Vector3(SpawnPos1[randIdx].transform.position.x, SpawnPos1[randIdx].transform.position.y, posZParticle) , transform.rotation, transform);
            shell.GetComponent<BulletParticle>().shootDir = posCanon1.transform.position - SpawnPos1[randIdx].transform.position;
            Destroy(shell, lifeStimeBulle);
            var shell2 = Instantiate(bullet, new Vector3(SpawnPos2[randIdx].transform.position.x, SpawnPos2[randIdx].transform.position.y, posZParticle), transform.rotation, transform);
            shell2.GetComponent<BulletParticle>().shootDir = posCanon2.transform.position - SpawnPos2[randIdx].transform.position;
            Destroy(shell2, lifeStimeBulle);
        }
        timer += Time.deltaTime;
    }

    IEnumerator delaySpawnBullet()
    {
        yield return new WaitForSeconds(fireRate);
        int randIdx = Random.Range(0, 9);
        var shell = Instantiate(bullet, SpawnPos1[randIdx].transform.position, transform.rotation, transform);

        shell.GetComponent<BulletEnnemy>().shootDir = posCanon1.transform.position - SpawnPos1[randIdx].transform.position;
        Destroy(shell, lifeStimeBulle); 


        StartCoroutine(delaySpawnBullet());
    }
}
