using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;


public class GameManagerWizardAndKnight : MonoBehaviour
{
    public static GameManagerWizardAndKnight instance;
    [SerializeField]
    private GameObject scoreUI;
    [SerializeField]
    private int unlockLvl = 3;       // Current unlocked level
    private int CurrentLvl;
    [SerializeField]
    private int score = 0;
    private bool hardDifficulty;
    private bool isKnight;
    private bool isArrowInputManager;   
    public enum language { ENG = 0, FRENCH = 1, SPANISH = 2 }
    private int currentLanguage = 0;
    private FadeWizardAndKnight fade;    //Fade to black UI
    [SerializeField]
    private HUDScoreLife lifeBar;                    // ref to black screen transition


    [SerializeField]
    public Locale espLocale;
    [SerializeField]
    public Locale engLocale;
    [SerializeField]
    public Locale frLocale;



    public static bool HasSettings { get; }

    private void Awake()
    {
          MakeSingleton();
    }


    //Constructor who check if is not already instanced
    public GameManagerWizardAndKnight MakeSingleton()
    {
        if (instance == null)
        {
            instance = this;
        }
        
        return instance;
    }

    void Start()
    {
        StartCoroutine(LoadingScene.LoadYourAsyncScene("MenuScene", ""));       // Load main menu scene 
        fade = GameObject.FindObjectOfType<FadeWizardAndKnight>();        // get fade black scrren
        lifeBar = GameObject.FindObjectOfType<HUDScoreLife>(); // Get ref to life UI 
        
    }


    //Set life bar player 
    public void SetScoreText(int scoreTexte)
    {
        score += scoreTexte;
        lifeBar.SetTexteScore(score);     // Sette UI Life Bar hero
    }
    //Set life bar player 
    public void SetLifeBarPlayer(int healt)
    {
        lifeBar.SetLifeBar(healt);     // Sette UI Life Bar hero
    }


    //Made UI life bar invisible
    public void SetLifeBarInvisible(bool onOff)
    {
        lifeBar.SetInvisible(onOff);     // Sette UI Life Bar hero
    }


    //Fade to black screen Whithout revert
    public void CallFade(bool isEnterCave)
    {
        StartCoroutine(fade.Lerp(isEnterCave));
    }

    public bool IsFadeEnd()
    {
        return fade.LerpIsEnd();
    }

    //Fade to normal screen 
    public void CallUnFade()
    {
        StartCoroutine(fade.RevertLerp());
    }


    //Setter current level befor change scene
    public void SetterCurrentLvl(int lvl)
    {
        CurrentLvl = lvl;
    }


    //Getter current level
    public int GetterCurrentLvl()
    {
        return CurrentLvl;
    }


    //Setter unlock level 
    public void SetterUnlockLvl()
    {
        if(CurrentLvl == 1)     // if current level is 1
        {
            if(unlockLvl < 2)
                unlockLvl++;    // unlock next level
        }
        if (CurrentLvl == 2)    // if current level is 2
        {
            if (unlockLvl < 3)
                unlockLvl++;       // unlock next level
        }
    }

    //Getter Unlock current level
    public int GetterUnlockLvl()
    {
        return unlockLvl;
    }


    //Setter difficulty game
    public void SetterHardDifficulty(bool onOff)
    {
        hardDifficulty = onOff;
    }


    //Getter difficulty game
    public bool GetterHardDifficulty()
    {
        return hardDifficulty;
    }


    //Setter Language game
    public void SetterLanguage(language lang)
    {
        currentLanguage = (int)lang;
        if (lang == language.ENG)
        {
            LocalizationSettings.SelectedLocale = engLocale;  //Set language to english
        }
        else if(lang == language.FRENCH)
        {
            LocalizationSettings.SelectedLocale = frLocale;  //Set language to French
        }
        else
            LocalizationSettings.SelectedLocale = espLocale;  //Set language to Spanish
    }


    //Getter current Language game
    public int GetterLanguage()
    {
        return currentLanguage;
    }


    //Setter Player character
    public void SetterIsKnight(bool onOff)
    {
        isKnight = onOff;
    }



    //Getter Player character
    public bool GetterIsKnight()
    {
        return isKnight;
    }


    //Setter  Input controller
    public void SetterIsArrowInputManager(bool onOff)
    {
        isArrowInputManager = onOff;
    }


    //Getter  Input controller
    public bool GetterIsArrowInputManager()
    {
        return isArrowInputManager;
    }

    public void SetUIScore(bool onOff)
    {
        scoreUI.SetActive(onOff);
    }
}
