using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameActive = false;
    public GameObject player;
    public GameObject mainScreen;
    public Text highScore;
    public Text textScore;
    public Text textTimer;
    public Fade blackScreen;

    public static float tombScore = 0;
    float StartBuffer = 1.0f;
    public float generalScoreTimer = 3000;
    float transitionTimer = 0;
    public float maxTimerValue = 1.5f;
    private bool doOnce = true;

    // Start is called before the first frame update
    void Start()
    {
        tombScore = 0;
        gameActive = false;
        mainScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameActive)
        {

            updateHuD();

            if (player.GetComponent<ExplorerMovement>().endState)
            {
                transitionTimer += Time.deltaTime;
            }
            else
            {
                if (generalScoreTimer > 0)
                {
                    generalScoreTimer -= Time.deltaTime * 20;
                }
                else
                {
                    generalScoreTimer = 0;
                }
                

            }

            if (transitionTimer > maxTimerValue)
            {
                if (PlayerPrefs.HasKey("tombScore"))
                {
                    if (PlayerPrefs.GetInt("tombScore")<tombScore)
                    {
                        PlayerPrefs.SetInt("tombScore", (int)tombScore);
                    }
                    
                }
                this.gameObject.GetComponent<AudioSource>().Stop();
                gameActive = false;
                mainScreen.SetActive(true);
            }
        }
        else if (Input.anyKey && StartBuffer <= 0)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if(doOnce)
                {
                    doOnce = false;
                    StartCoroutine(ReturnScene());
                }
            }
            else
            {
                resetGame();
            }
            

        }
        else
        {
            
            int value = PlayerPrefs.GetInt("tombScore");
            highScore.text = "HighScore\n" + value;
            StartBuffer -= Time.deltaTime;

        }
    }

    public IEnumerator ReturnScene()
    {
        StartCoroutine(blackScreen.Lerp(false));
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainArcade");
    }

    public void IncrementScore(int Value)
    {
        tombScore += Value;
    }

    public void TimeScore()
    {
        tombScore += (int)generalScoreTimer;
    }

    public void resetGame()
    {
        StartBuffer = 1;
        generalScoreTimer = 3000;
        transitionTimer = 0;
        tombScore = 0;
        gameActive = true;
        mainScreen.SetActive(false);
        this.gameObject.GetComponent<AudioSource>().Play();
        player.GetComponent<ExplorerMovement>().RestartLevel();
    }

    void updateHuD()
    {
        int adjustedTime = (int)generalScoreTimer;
        textTimer.text = "TIME\n" + adjustedTime;
        textScore.text = "SCORE\n" + tombScore;

    }

    public bool GameState()
    {
        return gameActive;
    }
}
