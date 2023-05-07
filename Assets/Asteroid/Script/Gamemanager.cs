using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] Text scoreText;
    [SerializeField] Text waveText;

    [SerializeField] float timerPerWave = 30f;
    [SerializeField] float spawnTimePerWave = 0.2f;
    [SerializeField] float spawnTime = 1f;
    [SerializeField] float showWaveTime = 1.5f;
    [SerializeField] Canvas highscoreCanvas;
    [SerializeField] GameObject SpaceShipPrefab;

    Vector3 spaceShipSpawnPos;
    float waveTimer = 0;
    int waveCounter = 0;

    public enum GameFlowState
    {
        InMenu,
        InLvl,
        PlayerIsDead
    }

    GameFlowState MyState = GameFlowState.InMenu;
    int score = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        waveText.gameObject.SetActive(false);
        spaceShipSpawnPos = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    void Update()
    {
        switch (MyState)
        {
            case GameFlowState.InMenu:

                score = 0;
                scoreText.text = "Score: " + score.ToString();
                waveCounter = 0;

                if (!GameObject.FindGameObjectWithTag("Player"))
                {
                    Instantiate(SpaceShipPrefab, spaceShipSpawnPos, Quaternion.Euler(90f, 0f, 0f));
                }

                break;

            case GameFlowState.InLvl:
                scoreText.text = "Score: " + score.ToString();

                waveTimer += Time.deltaTime;

                if (waveTimer >= timerPerWave && spawnTime != spawnTimePerWave)
                {
                    waveCounter++;

                    spawnTime -= spawnTimePerWave * waveCounter;

                    if (spawnTime <= 0)
                    {
                        spawnTime = spawnTimePerWave;
                        waveText.text = "Endless Wave, Good Luck";
                        StartCoroutine(ShowWave(showWaveTime));
                    } 
                    else
                    {
                        waveText.text = "Wave " + (waveCounter + 1).ToString();
                        StartCoroutine(ShowWave(showWaveTime));
                    }

                    waveTimer = 0;
                }
                break;

            case GameFlowState.PlayerIsDead:
                highscoreCanvas.gameObject.SetActive(true);
                break;
        }
    }

    public void PlayGame()
    {
        mainMenu.SetActive(false);

        foreach (var aAsteroid in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            Destroy(aAsteroid);
        }

        MyState = GameFlowState.InLvl;
        StartCoroutine(ShowWave(showWaveTime));
    }

    public void AddPoint(int PointToAdd)
    {
        if (MyState == GameFlowState.InLvl)
        {
            score += PointToAdd * (waveCounter + 1);
        }
    }

    public bool IsInGame()
    {
        return MyState == GameFlowState.InLvl;
    }

    public bool PlayerIsDead()
    {
        return MyState == GameFlowState.PlayerIsDead;
    }

    public float GetSpawnTimer()
    {
        return spawnTime;
    }

    public int GetMyScore()
    {
        return score;
    }

    public void ChangeStateToDead()
    {
        if (MyState == GameFlowState.InLvl)
        {
            MyState = GameFlowState.PlayerIsDead;
        }
    }

    public void ChangeStateToInMenu()
    {
        MyState = GameFlowState.InMenu;
    }

    IEnumerator ShowWave(float duration)
    {
        waveText.gameObject.SetActive(true);
        float startValue = waveText.color.a;
        float time = 0;

        while (time < duration)
        {
            waveText.color = new Color(waveText.color.r, waveText.color.g, waveText.color.b, Mathf.Lerp(startValue, 1, time / duration));
            time += Time.deltaTime;
            yield return null;
        }

        waveText.color = new Color(waveText.color.r, waveText.color.g, waveText.color.b, 0f);
        waveText.gameObject.SetActive(false);
    }
}
