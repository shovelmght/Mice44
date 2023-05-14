using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefBulletHell : MonoBehaviour
{
    public SavePlayerPrefBulletHell plPref;
    public GameManagerBulletHell gamemanager;
    public InputField texBox;
    private bool doOnce = true;

    private void Start()
    {
        plPref = GetComponent<SavePlayerPrefBulletHell>();
    }
    public void clickSaveButton()
    {
        if (doOnce)
        {
            doOnce = false;
            if (PlayerPrefs.GetString("ScoreBullet") == "")
            {
                PlayerPrefs.SetString("name1Bullet", texBox.text);
                PlayerPrefs.SetString("ScoreBullet", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("ScoreBullet")))
            {
                PlayerPrefs.SetString("name1Bullet", texBox.text);
                PlayerPrefs.SetString("ScoreBullet", gamemanager.GetScore().ToString());
            }

            plPref.SetPreft();
        }

    }

    public void SetScorePref()
    {
        PlayerPrefs.SetString("ScoreManagerBullet", gamemanager.GetScore().ToString());
    }
}
