
using UnityEngine;
using UnityEngine.UI;

public class SavePlayerPref : MonoBehaviour
{
    public PinBallGameManager gameManager;
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
        if (PlayerPrefs.GetString("Score") != "")
        {

                nameBox.text = PlayerPrefs.GetString("name1");
                hiScoreBox.text = PlayerPrefs.GetString("Score");
            
        }


        if (PlayerPrefs.GetString("ScoreManager") != "")
        {
            hiScoreBoxScoreBox.text = PlayerPrefs.GetString("ScoreManager");
        }


        if (gameManager.GetIsSceneScore())
        {
            nameBox2.text = PlayerPrefs.GetString("name2");
            hiScoreBox2.text = PlayerPrefs.GetString("Score2");
            nameBox3.text = PlayerPrefs.GetString("name3");
            hiScoreBox3.text = PlayerPrefs.GetString("Score3");
            nameBox4.text = PlayerPrefs.GetString("name4");
            hiScoreBox4.text = PlayerPrefs.GetString("Score4");
            nameBox5.text = PlayerPrefs.GetString("name5");
            hiScoreBox5.text = PlayerPrefs.GetString("Score5");
            nameBox6.text = PlayerPrefs.GetString("name6");
            hiScoreBox6.text = PlayerPrefs.GetString("Score6");
            nameBox7.text = PlayerPrefs.GetString("name7");
            hiScoreBox7.text = PlayerPrefs.GetString("Score7");
            nameBox8.text = PlayerPrefs.GetString("name8");
            hiScoreBox8.text = PlayerPrefs.GetString("Score8");
            nameBox9.text = PlayerPrefs.GetString("name9");
            hiScoreBox9.text = PlayerPrefs.GetString("Score9");
            nameBox10.text = PlayerPrefs.GetString("name10");
            hiScoreBox10.text = PlayerPrefs.GetString("Score10");

        }
    }

    public void SetPreft()
    {
        nameBox.text = PlayerPrefs.GetString("name1");
        hiScoreBox.text = PlayerPrefs.GetString("Score");
        nameBox2.text = PlayerPrefs.GetString("name2");
        hiScoreBox2.text = PlayerPrefs.GetString("Score2");
        nameBox3.text = PlayerPrefs.GetString("name3");
        hiScoreBox3.text = PlayerPrefs.GetString("Score3");
        nameBox4.text = PlayerPrefs.GetString("name4");
        hiScoreBox4.text = PlayerPrefs.GetString("Score4");
        nameBox5.text = PlayerPrefs.GetString("name5");
        hiScoreBox5.text = PlayerPrefs.GetString("Score5");
        nameBox6.text = PlayerPrefs.GetString("name6");
        hiScoreBox6.text = PlayerPrefs.GetString("Score6");
        nameBox7.text = PlayerPrefs.GetString("name7");
        hiScoreBox7.text = PlayerPrefs.GetString("Score7");
        nameBox8.text = PlayerPrefs.GetString("name8");
        hiScoreBox8.text = PlayerPrefs.GetString("Score8");
        nameBox9.text = PlayerPrefs.GetString("name9");
        hiScoreBox9.text = PlayerPrefs.GetString("Score9");
        nameBox10.text = PlayerPrefs.GetString("name10");
        hiScoreBox10.text = PlayerPrefs.GetString("Score10");
    }


}