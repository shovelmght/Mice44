using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class PinBallGameManager : MonoBehaviour
{
    public GameObject[] balls;
    public MusicManagerPinBall musicManager;
    public LerpUI blackScreen;
    public GameObject screenBlack;
    public int ballInGame = 1;
    private bool doOnce = true;
    private bool isGameEnd = false;
    private bool newScore = false;
    private bool isChangingScene = false;
    public int score = 0;
    public bool isScoreScene = false;
    public bool isMenuScene = false;
    private float timer = 0;
    private float endTimer = 4;
    public GameObject nameBox;
    public GameObject save;
    public LerpUI uiGameOver;
    public LerpUI uiSnewScore;
    public LerpUI BoxTextName;
    public LerpUI BoxTextScore;
    public LerpUI BoxButtonQuit;
    public LerpUI MainMenu;
    public LerpText MainMenuTxt;
    public LerpText QuitTxt;
    public LerpText saveTxt;
    public LerpText nameTxt;
    public PillarType3 pillarType3;
    private AudioSource m_AudioSource;
    [SerializeField] private AudioClip[] sound;
    public GameObject hi;
    public GameObject hiScore;
    public GameObject scoreTxt;
    public GameObject by;
    public GameObject boxName;


    public float delayLerp;



    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        musicManager = MusicManagerPinBall.FindObjectOfType<MusicManagerPinBall>();

        if (isScoreScene)
        {
            score = Convert.ToInt32(PlayerPrefs.GetString("ScoreManager"));


            if(PlayerPrefs.GetString("Score10") == "" || PlayerPrefs.GetString("Score9") == "" || PlayerPrefs.GetString("Score8") == "" || PlayerPrefs.GetString("Score7") == "" || PlayerPrefs.GetString("Score6") == "" || PlayerPrefs.GetString("Score5") == "" || PlayerPrefs.GetString("Score4") == "" || PlayerPrefs.GetString("Score3") == "" || PlayerPrefs.GetString("Score2") == "" || PlayerPrefs.GetString("Score") == "")
            {
                if(PlayerPrefs.GetString("ScoreManager") == "0")
                {
                    nameBox.SetActive(false);
                    save.SetActive(false);
                }
            }
            else
            {
                if (PlayerPrefs.GetString("Score10") != "")
                {
                    if (GetScore() < Convert.ToInt32(PlayerPrefs.GetString("Score10")))
                    {
                        nameBox.SetActive(false);
                        save.SetActive(false);
                    }
                }
                else if (PlayerPrefs.GetString("Score9") != "")
                {
                    if (GetScore() < Convert.ToInt32(PlayerPrefs.GetString("Score9")))
                    {
                        nameBox.SetActive(false);
                        save.SetActive(false);
                    }
                }
                else if (PlayerPrefs.GetString("Score8") != "")
                {
                    if (GetScore() < Convert.ToInt32(PlayerPrefs.GetString("Score8")))
                    {
                        nameBox.SetActive(false);
                        save.SetActive(false);
                    }
                }
                else if (PlayerPrefs.GetString("Score7") != "")
                {
                    if (GetScore() < Convert.ToInt32(PlayerPrefs.GetString("Score7")))
                    {
                        nameBox.SetActive(false);
                        save.SetActive(false);
                    }
                }
                else if (PlayerPrefs.GetString("Score6") != "")
                {
                    if (GetScore() < Convert.ToInt32(PlayerPrefs.GetString("Score6")))
                    {
                        nameBox.SetActive(false);
                        save.SetActive(false);
                    }
                }
                else if (PlayerPrefs.GetString("Score5") != "")
                {
                    if (GetScore() < Convert.ToInt32(PlayerPrefs.GetString("Score5")))
                    {
                        nameBox.SetActive(false);
                        save.SetActive(false);
                    }
                }
                else if (PlayerPrefs.GetString("Score4") != "")
                {
                    if (GetScore() < Convert.ToInt32(PlayerPrefs.GetString("Score4")))
                    {
                        nameBox.SetActive(false);
                        save.SetActive(false);
                    }
                }
                else if (PlayerPrefs.GetString("Score3") != "")
                {
                    if (GetScore() < Convert.ToInt32(PlayerPrefs.GetString("Score3")))
                    {
                        nameBox.SetActive(false);
                        save.SetActive(false);
                    }
                }
                else if (PlayerPrefs.GetString("Score2") != "")
                {
                    if (GetScore() < Convert.ToInt32(PlayerPrefs.GetString("Score2")))
                    {
                        nameBox.SetActive(false);
                        save.SetActive(false);
                    }
                }
                else if (PlayerPrefs.GetString("Score") != "")
                {
                    if (GetScore() < Convert.ToInt32(PlayerPrefs.GetString("Score")))
                    {
                        nameBox.SetActive(false);
                        save.SetActive(false);
                    }
                }
            }

            SetballInGame(-1);
        }
        else
        {
            if(!isMenuScene)
            {
             

            if (PlayerPrefs.GetString("Score") == "")
            {
                hi.SetActive(false);
                scoreTxt.SetActive(false);
                by.SetActive(false);
                boxName.SetActive(false);
                hiScore.SetActive(false);
            }
            }
            PlayerPrefs.SetString("ScoreManager", "0");
            score = 0;

        }

        StartCoroutine(blackScreen.RevertLerp(true));
        m_AudioSource = GetComponent<AudioSource>();
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !isMenuScene )
        {
            if(!isScoreScene)
            {
                PlayAudio();
            }
        
        }

        if (Input.GetKeyDown(KeyCode.D) && !isMenuScene)
        {
            if (!isScoreScene)
            {
                PlayAudio();
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerPrefs.DeleteAll();
        }

        //if(timer > endTimer)
        //{
        //    timer = 0;
            balls = GameObject.FindGameObjectsWithTag("Ball");
        //for (int i = 0; i < balls.Length; i++)
        //{
            //balls[i].GetComponent<Rigidbody>().velocity = new Vector3(balls[i].GetComponent<Rigidbody>().velocity.x, balls[i].GetComponent<Rigidbody>().velocity.y - 4, balls[i].GetComponent<Rigidbody>().velocity.z); ;
        //}
            if(balls.Length < 2)
            {
                SetballInGame(-2);
            }
        //}
        //timer += Time.deltaTime;
    }
    public void SetballInGame(int ball)
    {
        ballInGame += ball;
        if (ballInGame <= 0)
        {
            if (doOnce && !isMenuScene)
            {
                isGameEnd = true;

                if (!isScoreScene)
                {
                    if (score != 0)
                    {
                        if (PlayerPrefs.GetString("Score10") == "")
                        {
                            StartCoroutine(ChangeSceneScore());
                        }
                        else
                        {
                            if (GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score10")))
                            {
                                StartCoroutine(ChangeSceneScore());
                            }
                        }

                        if (PlayerPrefs.GetString("Score9") == "")
                        {
                            StartCoroutine(ChangeSceneScore());
                        }
                        else
                        {
                            if (GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score9")))
                            {
                                StartCoroutine(ChangeSceneScore());
                            }
                        }

                        if (PlayerPrefs.GetString("Score8") == "")
                        {
                            StartCoroutine(ChangeSceneScore());
                        }
                        else
                        {
                            if (GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score8")))
                            {
                                StartCoroutine(ChangeSceneScore());
                            }
                        }

                        if (PlayerPrefs.GetString("Score7") == "")
                        {
                            StartCoroutine(ChangeSceneScore());
                        }
                        else
                        {
                            if (GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score7")))
                            {
                                StartCoroutine(ChangeSceneScore());
                            }
                        }

                        if (PlayerPrefs.GetString("Score6") == "")
                        {
                            StartCoroutine(ChangeSceneScore());
                        }
                        else
                        {
                            if (GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score6")))
                            {
                                StartCoroutine(ChangeSceneScore());
                            }
                        }

                        if (PlayerPrefs.GetString("Score5") == "")
                        {
                            StartCoroutine(ChangeSceneScore());
                        }
                        else
                        {
                            if (GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score5")))
                            {
                                StartCoroutine(ChangeSceneScore());
                            }
                        }

                        if (PlayerPrefs.GetString("Score4") == "")
                        {
                            StartCoroutine(ChangeSceneScore());
                        }
                        else
                        {
                            if (GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score4")))
                            {
                                StartCoroutine(ChangeSceneScore());
                            }
                        }

                        if (PlayerPrefs.GetString("Score3") == "")
                        {
                            StartCoroutine(ChangeSceneScore());
                        }
                        else
                        {
                            if (GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score3")))
                            {
                                StartCoroutine(ChangeSceneScore());
                            }
                        }

                        if (PlayerPrefs.GetString("Score2") == "")
                        {
                            StartCoroutine(ChangeSceneScore());
                        }
                        else
                        {
                            if (GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score2")))
                            {
                                StartCoroutine(ChangeSceneScore());
                            }
                        }

                        if (PlayerPrefs.GetString("Score") == "")
                        {
                            StartCoroutine(ChangeSceneScore());
                        }
                        else
                        {
                            if (GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score")))
                            {
                                StartCoroutine(ChangeSceneScore());
                            }
                        }

                        if(!newScore)
                        {
                            m_AudioSource.pitch = 2;
                            m_AudioSource.volume = 0.5f;
                            m_AudioSource.PlayOneShot(sound[3]);
                            StartCoroutine(uiGameOver.Lerp(false));
                        }
                    }
                    else
                    {
                        m_AudioSource.pitch = 2;
                        m_AudioSource.volume = 0.5f;
                        m_AudioSource.PlayOneShot(sound[3]);
                        StartCoroutine(uiGameOver.Lerp(false));
                    }
                }

                if (isScoreScene)
                {
                    doOnce = false;
                    pillarType3.SetGameOverEvent(true);
                    StartCoroutine(QuitTxt.Lerp());
                    StartCoroutine(BoxButtonQuit.Lerp(false));
                }
                else
                {
                    doOnce = false;
                    if (!newScore)
                    {
                        StartCoroutine(BoxTextName.Lerp(false));
                        StartCoroutine(BoxTextScore.Lerp(false));
                        StartCoroutine(MainMenu.Lerp(false));
                        StartCoroutine(MainMenuTxt.Lerp());
                        StartCoroutine(nameTxt.Lerp());
                        StartCoroutine(saveTxt.Lerp());
                        StartCoroutine(QuitTxt.Lerp());
                        StartCoroutine(BoxButtonQuit.Lerp(false));
                    }
                    pillarType3.SetGameOverEvent(true);
                }
            }
        }
    }

    public void Setscore(int addScore)
    {
        if (ballInGame > 0 && !isScoreScene)
            score += addScore;
    }

    public int GetScore()
    {
        return score;
    }

    public bool GetIsEndGame()
    {
        return isGameEnd;
    }

    public bool GetisMenuScene()
    {
        return isMenuScene;
    }

    public bool GetisScoreScene()
    {
        return isScoreScene;
    }
    public bool GetisChangingScene()
    {
        return isChangingScene;
    }

    public int GetBallinGame()
    {
        return ballInGame;
    }



    private void PlayAudio()
    {
        m_AudioSource.pitch = Random.Range(1.7f, 2.2f);
        int n = Random.Range(1, 2);
        m_AudioSource.clip = sound[n];
        m_AudioSource.PlayOneShot(m_AudioSource.clip);
        sound[n] = sound[0];
        sound[0] = m_AudioSource.clip;
    }

    public bool GetIsSceneScore()
    {
        return isScoreScene;
    }

    public void PlayButton()
    {
        StartCoroutine(ChangeScene("Play Scene"));
    }

    public void ScoreButton()
    {
        StartCoroutine(ChangeScene("Score Scene"));
    }
    public void MainMenuButton()
    {
        StartCoroutine(ChangeScene("SuperPinBallScene"));
    }
    public void Quit()
    {
        StartCoroutine(ChangeScene("MainArcadeScene"));
    }

    public IEnumerator ChangeScene(String scene)
    {
        screenBlack.SetActive(true);
        isChangingScene = true;
        StartCoroutine(musicManager.FadeOut());
        yield return new WaitForSeconds(delayLerp);

        StartCoroutine(blackScreen.Lerp(true));
        while (!blackScreen.LerpIsEnd())
        {
            yield return null;
        }
        SceneManager.LoadScene(scene);
    }

    public IEnumerator ChangeSceneScore()
    {
        m_AudioSource.pitch = 2;
        m_AudioSource.volume = 0.06f;
        m_AudioSource.PlayOneShot(sound[2]);
        PlayerPrefs.SetString("ScoreManager", GetScore().ToString());
        newScore = true;
        StartCoroutine(uiSnewScore.Lerp(false));
        yield return new WaitForSeconds(3);
        StartCoroutine(ChangeScene("Score Scene"));
    }
}