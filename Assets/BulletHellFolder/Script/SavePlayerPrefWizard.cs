using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePlayerPrefWizard : MonoBehaviour
{
    public Text hiScoreBox;

    
    void Start()
    {
        Debug.Log("wizard Start player preff GetScore() = " + GameManagerWizardAndKnight.instance.GetScore());
        //Debug.Log("wizard Start player preff PlayerPrefs.GetString(ScoreWizard) = " + Convert.ToInt32(PlayerPrefs.GetString("ScoreWizard")));
        
        
        if (PlayerPrefs.GetString("ScoreWizard") == "")
        {
            PlayerPrefs.SetString("ScoreWizard", GameManagerWizardAndKnight.instance.GetScore().ToString());
        }
        else if (GameManagerWizardAndKnight.instance.GetScore() > Convert.ToInt32(PlayerPrefs.GetString("ScoreWizard")))
        {
            PlayerPrefs.SetString("ScoreWizard", GameManagerWizardAndKnight.instance.GetScore().ToString());
        }

        SetPreft();
    
        if (PlayerPrefs.GetString("ScoreWizard") != "")
        {
            hiScoreBox.text = PlayerPrefs.GetString("ScoreWizard");
        }
    }
    
    public void SetPreft()
    {
        hiScoreBox.text = PlayerPrefs.GetString("ScoreWizard");
    }
}
