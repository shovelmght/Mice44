using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerFlappyBird : MonoBehaviour
{
    [SerializeField] GameObject PipeSpawner;
    [SerializeField] GameObject PipeCombo;
    [SerializeField] float GameSpeed = 2f;
    [SerializeField] float MaxTimer;
    [SerializeField] float MinTimer;
    [SerializeField] float SpeedModifier;
    [SerializeField] float MaxSpeed;
    [SerializeField] Text ScoreText;
    [SerializeField] GameObject GameOverParent;
    [SerializeField] GameObject HighScoreTxt;
    [SerializeField] Text EndScoreNum;
    [SerializeField] Text NewHighscoreNum;
    private float SpawnHeightRange = 20;
    private float timer = 0;
    private float height = 0;
    MoveLeft PipeSpeed;
    bool Playing = false;
    public GameObject blackScreen;
    public GameObject canvas;

    private void Awake()
    {
        Time.timeScale = 0;
        Cursor.lockState = 0;
        PipeSpeed = PipeCombo.GetComponent<MoveLeft>();
        PipeSpeed.SetSpeed(GameSpeed);
        PlayerPrefs.SetInt("FBscore", 0);
    }
    void Start()
    {
        SpawnPipe();
        GameOverParent.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= MaxTimer)
        {
            SpawnPipe();
            timer = 0;
            if (MaxTimer >= MinTimer)
            {
                MaxTimer -= SpeedModifier;
                Debug.Log("Timer: " + MaxTimer + " , Speed: " + PipeSpeed.GetSpeed());
            }
            if (GameSpeed < MaxSpeed)
            {
                PipeSpeed.SetSpeed(PipeSpeed.GetSpeed() + SpeedModifier * 10);
            }
        }

        timer += Time.deltaTime;
        UpdateScore();
        CheckPlaying();
    }

    void SpawnPipe()
    {
        GameObject NewPipe = Instantiate(PipeCombo);
        height = Random.Range(-SpawnHeightRange, SpawnHeightRange);
        NewPipe.transform.position = PipeSpawner.transform.position + new Vector3(0, height, 0);
        Destroy(NewPipe, 10f);
    }
    void UpdateScore()
    {
        ScoreText.text = PlayerPrefs.GetInt("FBscore").ToString();
    }
    void CheckPlaying()
    {
        if (!Playing)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    public bool IsPlaying()
    {
        return Playing;
    }

    public void StartGame()
    {
        Playing = true;
    }

    public void SetPlaying(bool isPlaying)
    {
        Playing = isPlaying;
    }
    public void GameOverFB()
    {
        EndScoreNum.text = PlayerPrefs.GetInt("FBscore").ToString();
        Playing = false;
        GameOverParent.SetActive(true);
    }
    public void NewHighscore()
    {
        HighScoreTxt.SetActive(true);
        PlayerPrefs.SetInt("FBhighscore", PlayerPrefs.GetInt("FBscore"));
        NewHighscoreNum.text = PlayerPrefs.GetInt("FBhighscore").ToString();
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene("Flappy Bird");
    }
    public void LeaveGame()
    {
        Playing = true;
        SceneManager.LoadScene("MainArcade");
    }

    public void OnExitGame()
    {
        Instantiate(blackScreen, new Vector3(0, 0, 0), Quaternion.identity, canvas.transform);
    }

    public IEnumerator ReturnScene()
    {

        yield return new WaitForSeconds(2f);
      
    }
}
