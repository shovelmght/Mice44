using System;
using System.Collections;
using System.Collections.Generic;
using LesserKnown.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SavePlayerPrefSoulRunner : MonoBehaviour
{
    public TMP_Text hiScoreBox;
    [SerializeField] private UIManager _UIManager;
    void Start()
    {
        SetPreft();
    }
    
    
    
    public void SetPreft()
    {
        Debug.Log("SoulRunner Start player preff GetScore() = " +_UIManager.GetScore().GetScore());
        //Debug.Log("wizard Start player preff PlayerPrefs.GetString(ScoreWizard) = " + Convert.ToInt32(PlayerPrefs.GetString("ScoreWizard")));
        
        
        if (PlayerPrefs.GetString("ScoreSoulRunner") == "")
        {
            PlayerPrefs.SetString("ScoreSoulRunner", _UIManager.GetScore().GetScore().ToString());
        }
        else if (_UIManager.GetScore().GetScore() > Convert.ToInt32(PlayerPrefs.GetString("ScoreSoulRunner")))
        {
            PlayerPrefs.SetString("ScoreSoulRunner",_UIManager.GetScore().GetScore().ToString());
        }

        if (PlayerPrefs.GetString("ScoreSoulRunner") != "")
        {
            hiScoreBox.text = PlayerPrefs.GetString("ScoreSoulRunner");
        }
        else
        {
            hiScoreBox.text = "0";
        }
    }
}
