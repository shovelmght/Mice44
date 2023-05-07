using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MainMenu : MonoBehaviour
{
    //is for change color buttonLevel dont unlocked
    private GameObject buttomLvl_2;
    private Image imageLvl_2;
    private GameObject buttomLvl_3;
    private Image imageLvl_3;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        //Get and check if level is unlocked
        //if yes, change color of button
        buttomLvl_2 = GameObject.Find("Button lvl 2");
        imageLvl_2 = buttomLvl_2.GetComponent<Image>();  
        if (GameManagerWizardAndKnight.instance.GetterUnlockLvl() >= 2)
            imageLvl_2.color = new Color(1, 1, 1, 1);

        //Get and check if level is unlocked
        //if yes, change color of button
        buttomLvl_3 = GameObject.Find("Button lvl 3");
        imageLvl_3 = buttomLvl_3.GetComponent<Image>();   
        if (GameManagerWizardAndKnight.instance.GetterUnlockLvl() >= 3)
             imageLvl_3.color = new Color(1, 1, 1, 1);

    }


    //Enter to Level 1
    public void PlayLevel1()
    {
        StartCoroutine(DelayStartLvl1("Level_1"));  //Fade and load level 1
        GameManagerWizardAndKnight.instance.SetterCurrentLvl(1);   // Tell to Game Manager what is current level
    }


    //Enter to Level 2
    public void PlayLeve2()
    {
        if (GameManagerWizardAndKnight.instance.GetterUnlockLvl() >= 2)     // check if level 2 is unlocked
        {
            GameManagerWizardAndKnight.instance.SetterCurrentLvl(2);            //Fade and load level 1
            StartCoroutine(DelayStartLvl1("Level_2"));        // Tell to Game Manager what is current level
        }   
    }


    //Enter to Level 3
    public void PlayLeve3()
    {
        if (GameManagerWizardAndKnight.instance.GetterUnlockLvl() >= 3)   // check if level 2 is unlocked
        {
            GameManagerWizardAndKnight.instance.SetterCurrentLvl(3);          //Fade and load level 1
            StartCoroutine(DelayStartLvl1("Level_3"));       // Tell to Game Manager what is current level
        }
    }



      //Fade and load level chosen
    IEnumerator DelayStartLvl1(string scene)
    {
        StartCoroutine(MusicManagerWizard.instance.FadeOut());
        GameManagerWizardAndKnight.instance.CallFade(false);        //fade to black screen
        yield return new WaitForSeconds(2);    
        StartCoroutine(LoadingScene.LoadYourAsyncScene(scene, "MenuScene"));   // Unload Menu scene and load chosen level
    }



    // Set difficulty to hard
    public void SetDifficultyHard()
    {
        GameManagerWizardAndKnight.instance.SetterHardDifficulty(true);
    }


    // Set difficulty to normal
    public void SetDifficultyNormal()
    {
        GameManagerWizardAndKnight.instance.SetterHardDifficulty(false);
    }


    // Set language to english
    public void SetLanguageEnglish()
    {
        GameManagerWizardAndKnight.instance.SetterLanguage(GameManagerWizardAndKnight.language.ENG);
    }


    // Set language to French
    public void SetLanguageFrench()
    {
        GameManagerWizardAndKnight.instance.SetterLanguage(GameManagerWizardAndKnight.language.FRENCH);
    }


    // Set language to spanish
    public void SetLanguageSpanish()
    {
        GameManagerWizardAndKnight.instance.SetterLanguage(GameManagerWizardAndKnight.language.SPANISH);
    }


    // Set the chosen character
    public void SetIsWisard()
    {
        GameManagerWizardAndKnight.instance.SetterIsKnight(false);
    }


    // Set the chosen character
    public void SetIsKnight()
    {
        GameManagerWizardAndKnight.instance.SetterIsKnight(true);
    }


    // Set the chosen Input controller
    public void SetInputASDWInput()
    {
        GameManagerWizardAndKnight.instance.SetterIsArrowInputManager(true);
    }


    // Set the chosen Input controller
    public void SetInputArrowInput()
    {
        GameManagerWizardAndKnight.instance.SetterIsArrowInputManager(false);
    }


    //Quit game
    public void QuitGame()
    {
        StartCoroutine(QuitToArcadeScene());

    }

    IEnumerator QuitToArcadeScene()
    {
        GameManagerWizardAndKnight.instance.CallFade(false);        //fade to black screen
        StartCoroutine(MusicManagerWizard.instance.FadeOut());
        while (!GameManagerWizardAndKnight.instance.IsFadeEnd())
        {
            yield return null;
        }

        SceneManager.LoadScene("MainArcadeScene");
    }


}
