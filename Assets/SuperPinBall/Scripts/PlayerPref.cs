using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPref : MonoBehaviour
{
    public SavePlayerPref plPref;
    public PinBallGameManager gamemanager;
    public InputField texBox;
    private bool doOnce = true;

    private void Start()
    {
        plPref = GetComponent<SavePlayerPref>();

    }
    public void clickSaveButton()
    {
        if(doOnce)
        {
            doOnce = false;
            if (PlayerPrefs.GetString("Score") == "")
            {
                PlayerPrefs.SetString("name1", texBox.text);
                PlayerPrefs.SetString("Score", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score")))
            {
                PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
                PlayerPrefs.SetString("Score10", PlayerPrefs.GetString("Score9"));
                PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
                PlayerPrefs.SetString("Score9", PlayerPrefs.GetString("Score8"));
                PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
                PlayerPrefs.SetString("Score8", PlayerPrefs.GetString("Score7"));
                PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
                PlayerPrefs.SetString("Score7", PlayerPrefs.GetString("Score6"));
                PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
                PlayerPrefs.SetString("Score6", PlayerPrefs.GetString("Score5"));
                PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
                PlayerPrefs.SetString("Score5", PlayerPrefs.GetString("Score4"));
                PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
                PlayerPrefs.SetString("Score4", PlayerPrefs.GetString("Score3"));
                PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
                PlayerPrefs.SetString("Score3", PlayerPrefs.GetString("Score2"));
                PlayerPrefs.SetString("name2", PlayerPrefs.GetString("name1"));
                PlayerPrefs.SetString("Score2", PlayerPrefs.GetString("Score"));
                PlayerPrefs.SetString("name1", texBox.text);
                PlayerPrefs.SetString("Score", gamemanager.GetScore().ToString());
            }
            else if (PlayerPrefs.GetString("Score2") == "")
            {
                PlayerPrefs.SetString("name2", texBox.text);
                PlayerPrefs.SetString("Score2", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score2")))
            {
                PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
                PlayerPrefs.SetString("Score10", PlayerPrefs.GetString("Score9"));
                PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
                PlayerPrefs.SetString("Score9", PlayerPrefs.GetString("Score8"));
                PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
                PlayerPrefs.SetString("Score8", PlayerPrefs.GetString("Score7"));
                PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
                PlayerPrefs.SetString("Score7", PlayerPrefs.GetString("Score6"));
                PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
                PlayerPrefs.SetString("Score6", PlayerPrefs.GetString("Score5"));
                PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
                PlayerPrefs.SetString("Score5", PlayerPrefs.GetString("Score4"));
                PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
                PlayerPrefs.SetString("Score4", PlayerPrefs.GetString("Score3"));
                PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
                PlayerPrefs.SetString("Score3", PlayerPrefs.GetString("Score2"));
                PlayerPrefs.SetString("name2", texBox.text);
                PlayerPrefs.SetString("Score2", gamemanager.GetScore().ToString());
            }
            else if (PlayerPrefs.GetString("Score3") == "")
            {
                PlayerPrefs.SetString("name3", texBox.text);
                PlayerPrefs.SetString("Score3", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score3")))
            {
                PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
                PlayerPrefs.SetString("Score10", PlayerPrefs.GetString("Score9"));
                PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
                PlayerPrefs.SetString("Score9", PlayerPrefs.GetString("Score8"));
                PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
                PlayerPrefs.SetString("Score8", PlayerPrefs.GetString("Score7"));
                PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
                PlayerPrefs.SetString("Score7", PlayerPrefs.GetString("Score6"));
                PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
                PlayerPrefs.SetString("Score6", PlayerPrefs.GetString("Score5"));
                PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
                PlayerPrefs.SetString("Score5", PlayerPrefs.GetString("Score4"));
                PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
                PlayerPrefs.SetString("Score4", PlayerPrefs.GetString("Score3"));
                PlayerPrefs.SetString("name3", texBox.text);
                PlayerPrefs.SetString("Score3", gamemanager.GetScore().ToString());
            }
            else if (PlayerPrefs.GetString("Score4") == "")
            {
                PlayerPrefs.SetString("name4", texBox.text);
                PlayerPrefs.SetString("Score4", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score4")))
            {
                PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
                PlayerPrefs.SetString("Score10", PlayerPrefs.GetString("Score9"));
                PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
                PlayerPrefs.SetString("Score9", PlayerPrefs.GetString("Score8"));
                PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
                PlayerPrefs.SetString("Score8", PlayerPrefs.GetString("Score7"));
                PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
                PlayerPrefs.SetString("Score7", PlayerPrefs.GetString("Score6"));
                PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
                PlayerPrefs.SetString("Score6", PlayerPrefs.GetString("Score5"));
                PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
                PlayerPrefs.SetString("Score5", PlayerPrefs.GetString("Score4"));

                PlayerPrefs.SetString("name4", texBox.text);
                PlayerPrefs.SetString("Score4", gamemanager.GetScore().ToString());
            }
            else if (PlayerPrefs.GetString("Score5") == "")
            {
                PlayerPrefs.SetString("name5", texBox.text);
                PlayerPrefs.SetString("Score5", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score5")))
            {
                PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
                PlayerPrefs.SetString("Score10", PlayerPrefs.GetString("Score9"));
                PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
                PlayerPrefs.SetString("Score9", PlayerPrefs.GetString("Score8"));
                PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
                PlayerPrefs.SetString("Score8", PlayerPrefs.GetString("Score7"));
                PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
                PlayerPrefs.SetString("Score7", PlayerPrefs.GetString("Score6"));
                PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
                PlayerPrefs.SetString("Score6", PlayerPrefs.GetString("Score5"));
                PlayerPrefs.SetString("name5", texBox.text);
                PlayerPrefs.SetString("Score5", gamemanager.GetScore().ToString());
            }
            else if (PlayerPrefs.GetString("Score6") == "")
            {
                PlayerPrefs.SetString("name6", texBox.text);
                PlayerPrefs.SetString("Score6", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score6")))
            {
                PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
                PlayerPrefs.SetString("Score10", PlayerPrefs.GetString("Score9"));
                PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
                PlayerPrefs.SetString("Score9", PlayerPrefs.GetString("Score8"));
                PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
                PlayerPrefs.SetString("Score8", PlayerPrefs.GetString("Score7"));
                PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
                PlayerPrefs.SetString("Score7", PlayerPrefs.GetString("Score6"));
                PlayerPrefs.SetString("name6", texBox.text);
                PlayerPrefs.SetString("Score6", gamemanager.GetScore().ToString());
            }
            else if (PlayerPrefs.GetString("Score7") == "")
            {
                PlayerPrefs.SetString("name7", texBox.text);
                PlayerPrefs.SetString("Score7", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score7")))
            {
                PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
                PlayerPrefs.SetString("Score10", PlayerPrefs.GetString("Score9"));
                PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
                PlayerPrefs.SetString("Score9", PlayerPrefs.GetString("Score8"));
                PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
                PlayerPrefs.SetString("Score8", PlayerPrefs.GetString("Score7"));
                PlayerPrefs.SetString("name7", texBox.text);
                PlayerPrefs.SetString("Score7", gamemanager.GetScore().ToString());
            }
            else if (PlayerPrefs.GetString("Score8") == "")
            {
                PlayerPrefs.SetString("name8", texBox.text);
                PlayerPrefs.SetString("Score8", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score8")))
            {
                PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
                PlayerPrefs.SetString("Score10", PlayerPrefs.GetString("Score9"));
                PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
                PlayerPrefs.SetString("Score9", PlayerPrefs.GetString("Score8"));
                PlayerPrefs.SetString("name8", texBox.text);
                PlayerPrefs.SetString("Score8", gamemanager.GetScore().ToString());
            }
            else if (PlayerPrefs.GetString("Score9") == "")
            {
                PlayerPrefs.SetString("name9", texBox.text);
                PlayerPrefs.SetString("Score9", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score9")))
            {
                PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
                PlayerPrefs.SetString("Score10", PlayerPrefs.GetString("Score9"));
                PlayerPrefs.SetString("name9", texBox.text);
                PlayerPrefs.SetString("Score9", gamemanager.GetScore().ToString());
            }
            else if (PlayerPrefs.GetString("Score10") == "")
            {
                PlayerPrefs.SetString("name10", texBox.text);
                PlayerPrefs.SetString("Score10", gamemanager.GetScore().ToString());
            }
            else if (gamemanager.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("Score10")))
            {
                PlayerPrefs.SetString("name10", texBox.text);
                PlayerPrefs.SetString("Score10", gamemanager.GetScore().ToString());
            }

            plPref.SetPreft();
        }

    }

    public void SetScorePref()
    {
        PlayerPrefs.SetString("ScoreManager", gamemanager.GetScore().ToString());
    }
}