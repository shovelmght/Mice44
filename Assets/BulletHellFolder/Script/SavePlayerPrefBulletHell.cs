using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePlayerPrefBulletHell : MonoBehaviour
{
    public GameManagerBulletHell gameManager;
    public Text nameBox;
    public Text hiScoreBox;
    public Text nameBox2;
    public Text hiScoreBox2;
    public Text nameBox3;
    public Text hiScoreBox3;
    public Text nameBox4;
    public Text hiScoreBox4;
    public Text nameBox5;
    public Text hiScoreBox5;
    public Text nameBox6;
    public Text hiScoreBox6;
    public Text nameBox7;
    public Text hiScoreBox7;
    public Text nameBox8;
    public Text hiScoreBox8;
    public Text nameBox9;
    public Text hiScoreBox9;
    public Text nameBox10;
    public Text hiScoreBox10;
    public Text hiScoreBoxScoreBox;

    void Start()
    {
        if (PlayerPrefs.GetString("ScoreBullet") != "")
        {
            nameBox.text = PlayerPrefs.GetString("name1Bullet");
            hiScoreBox.text = PlayerPrefs.GetString("ScoreBullet");
        }

        if (PlayerPrefs.GetString("ScoreManagerBullet") != "")
        {
            hiScoreBoxScoreBox.text = PlayerPrefs.GetString("ScoreManagerBullet");
        }
    }

    public void SetPreft()
    {
        nameBox.text = PlayerPrefs.GetString("name1Bullet");
        hiScoreBox.text = PlayerPrefs.GetString("ScoreBullet");
    }

}
