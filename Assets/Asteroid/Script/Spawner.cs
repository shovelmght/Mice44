using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public enum SpawnSide
    {
        Up = 0,
        Down = 1,
        Right = 2,
        Left = 3
    }

    [SerializeField] float minSpawnPointZ = 0;
    [SerializeField] float maxSpawnPointZ = -11;

    [SerializeField] float minSpawnPointX = -11;
    [SerializeField] float maxSpawnPointX = 11;

    [SerializeField] float gameHeight = -5;
    [SerializeField] float spacingFromSpawn = 1.5f;

    [SerializeField] float minSpeedForce = 20;
    [SerializeField] float maxSpeedForce = 50;

    [SerializeField] int nbOfSpawnBeforeAi = 5;
    [SerializeField] float speedModifierPerWave = 1.2f;

    public GameObject asteroid;
    public GameObject meteorAi;
    
    
    public Transform[] spawnBorder;
    public Gamemanager gamemanager;

    int nbOfSpawnDone = 0;
    float timer = 0;
    SpawnSide spawningSide = SpawnSide.Down;

    private void Update()
    {
        if (gamemanager.IsInGame())
        { 
            timer += Time.deltaTime;

            if (timer >= gamemanager.GetSpawnTimer())
            {
                Spawn();
                timer = 0;
            }
        }
        else
        if (gamemanager.PlayerIsDead())
        {
            DestroyEverything();
        }
    }


    void Spawn()
    {
        spawningSide = (SpawnSide)Random.Range(0, spawnBorder.Length);

        switch (spawningSide)
        {
            case SpawnSide.Up:
                SpawnUpDown(-spacingFromSpawn, Vector3.back);
                break;
            case SpawnSide.Down:
                SpawnUpDown(spacingFromSpawn, Vector3.forward);
                break;
            case SpawnSide.Right:
                SpawnLeftRight(-spacingFromSpawn, Vector3.left);
                break;
            case SpawnSide.Left:
                SpawnLeftRight(spacingFromSpawn, Vector3.right);
                break;
            default:
                break;
        }
        nbOfSpawnDone++;
    }

    void SpawnUpDown(float spacing, Vector3 dir)
    {
        float spawnPointX = Random.Range(minSpawnPointX, maxSpawnPointX);

        if (nbOfSpawnDone == nbOfSpawnBeforeAi)
        {
            Instantiate(meteorAi, new Vector3(spawnPointX, gameHeight, spawnBorder[(int)spawningSide].position.z + spacing), Quaternion.identity);
            nbOfSpawnDone = 0;
        }

        var asteroidObject = Instantiate(asteroid, new Vector3(spawnPointX, gameHeight, spawnBorder[(int)spawningSide].position.z + spacing), Quaternion.Euler(90f, 0f, 0f));
        asteroidObject.GetComponent<Rigidbody>().AddForce(dir * Random.Range(minSpeedForce, maxSpeedForce));
    }

    void SpawnLeftRight(float spacing, Vector3 dir)
    {
        float spawnPointZ = Random.Range(minSpawnPointZ, maxSpawnPointZ);

        if (nbOfSpawnDone == nbOfSpawnBeforeAi)
        {
            Instantiate(meteorAi, new Vector3(spawnBorder[(int)spawningSide].position.x + spacing, gameHeight, spawnPointZ), Quaternion.identity);
            nbOfSpawnDone = 0;
        }

        var asteroidObject = Instantiate(asteroid, new Vector3(spawnBorder[(int)spawningSide].position.x + spacing, gameHeight, spawnPointZ), Quaternion.Euler(90f, 0f, 0f));
        asteroidObject.GetComponent<Rigidbody>().AddForce(dir * Random.Range(minSpeedForce, maxSpeedForce));
    }

    void DestroyEverything()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length > 0)
        { 
            foreach (var aAsteroid in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                Destroy(aAsteroid);
            }
        }
    }
}
