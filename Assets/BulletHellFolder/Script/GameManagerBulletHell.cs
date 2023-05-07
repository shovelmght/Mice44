using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerBulletHell : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI m_text;
    [SerializeField]
    private GameObject boss;
    [SerializeField]
    GameObject lifeBar;
    [SerializeField]
    private GameObject[] ships;
    [SerializeField]
    private GameObject[] spawnPoint;
    [SerializeField]
    private GameObject starGameUI;
    [SerializeField]
    private GameObject hiScoreStuff;
    [SerializeField]
    private GameObject stuffScorePref;
    [SerializeField]
    private GameObject HiScorePref;
    [SerializeField]
    private GameObject NewHiscoreTxt;
    [SerializeField]
    private GameObject blackSreen;
    [SerializeField]
    private GameObject txtWin;
    [SerializeField]
    private PlanePlayer playerPlane;
    [SerializeField]
    private AudioSource gameOverSound;
    [SerializeField]
    private AudioSource startGameSound;
    [SerializeField]
    private MusicManager musicManager;
    public float[] time;
    public float delayStart = 2;
    public float timeSpawnsManager = 10;
    public int[] idx;
    public int score = 0;
    public bool bossIsHere;
    private bool gameOver;
    private bool doOnce = true;
    private bool startBuffer = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOverSound = GetComponent<AudioSource>();
        StartCoroutine(DelayStart());
    }

    private void Update()
    {
        if (startBuffer)
        {
            if (Input.anyKey)
            {
                if (doOnce)
                {
                    doOnce = false;
                    StartCoroutine(SpawnManager());
                    starGameUI.GetComponent<Animator>().SetTrigger("Out");
                    playerPlane.OnEnable();
                    hiScoreStuff.SetActive(false);
                    lifeBar.SetActive(true);
                    m_text.enabled = true;
                    startGameSound.Play();
                }
            }
        }
    }

    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(delayStart);
        startBuffer = true;
    }

    IEnumerator SpawnManager()
    {
        StartCoroutine(Spawn1());
        yield return new WaitForSeconds(timeSpawnsManager);
        StartCoroutine(Spawn2());
        yield return new WaitForSeconds(timeSpawnsManager);
        StartCoroutine(Spawn3());
        yield return new WaitForSeconds(timeSpawnsManager);
        bossIsHere = true;
        StartCoroutine(SpawnBoss());

    }

    // Update is called once per frame
    IEnumerator Spawn1()
    {
        yield return new WaitForSeconds(time[0]);
        idx[0] = Random.Range(0, spawnPoint.Length);
        var ship1 = Instantiate(ships[0], spawnPoint[idx[0]].transform.position, Quaternion.identity);
        ship1.GetComponent<Ennemy>().gameManager = this;
        if(!bossIsHere)
            StartCoroutine(Spawn1());
    }

    IEnumerator Spawn2()
    {
        yield return new WaitForSeconds(time[1]);
        idx[0] = Random.Range(10, spawnPoint.Length);
        var ship2 =  Instantiate(ships[1], spawnPoint[idx[0]].transform.position, Quaternion.identity);
        ship2.GetComponent<BigShip>().gameManager = this;
        if (!bossIsHere)
        {
            if(!gameOver)
                StartCoroutine(Spawn2());
        }
           
    }
    IEnumerator Spawn3()
    {
        yield return new WaitForSeconds(time[2]);
        idx[0] = Random.Range(0, spawnPoint.Length);
        var ship2 = Instantiate(ships[2], spawnPoint[idx[0]].transform.position, Quaternion.identity);
        ship2.GetComponent<EnnemyAim>().gameManager = this;
        if (!bossIsHere)
        {
            if (!gameOver)
                StartCoroutine(Spawn3());
        }
    }

    IEnumerator SpawnBoss()
    {
        yield return new WaitForSeconds(10);
        if (!gameOver)
            boss.SetActive(true);
    }

    public void GameOver(bool isWin)
    {
        StartCoroutine(DelayGameOver(isWin));
    }
    IEnumerator DelayGameOver(bool isWin)
    {
       StartCoroutine(musicManager.ChangeSong(false));
        gameOver = true;
        if(isWin)
        {
            yield return new WaitForSeconds(4f);
            txtWin.SetActive(true);
            yield return new WaitForSeconds(4f);
            txtWin.SetActive(false);
        }
        blackSreen.SetActive(false);
        gameOverSound.Play();
        yield return new WaitForSeconds(1f);
        stuffScorePref.SetActive(true);
        Cursor.lockState = CursorLockMode.None;

        int.TryParse(HiScorePref.GetComponent<Text>().text, out int hiScore);
      
        if (score > hiScore)
        {
            NewHiscoreTxt.SetActive(true);
            hiScoreStuff.SetActive(true);
        }
        else
        {
            stuffScorePref.SetActive(true);
            HiScorePref.SetActive(true);
        }
    }


    public void OnClickReplay()
    {
        StartCoroutine(ChangeScene("BulletHell"));
    }
    public void OnClickQuit()
    {
        Time.timeScale = 1;
        StartCoroutine(ChangeScene("MainArcadeScene"));
    }

    public IEnumerator ChangeScene(string sceneName)
    {
        StartCoroutine(musicManager.FadeOut());
        blackSreen.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Fade fadeBlackScreen = blackSreen.GetComponent<Fade>();
         StartCoroutine(fadeBlackScreen.Lerp(false));
        while (!fadeBlackScreen.LerpIsEnd())
        {
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(sceneName);
      
    }

    public void SetScoreTxt(int point)
    {
        score += point;
        m_text.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
