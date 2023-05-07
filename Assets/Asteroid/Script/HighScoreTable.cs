using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour
{
    [SerializeField]
    int MaxSaveHighScore = 10;

    [SerializeField] Transform m_SaveTemplate;
    [SerializeField] Gamemanager gamemanager;
    List<Transform> m_HighScoreTransformList;

    bool ItsANewHighScore = false;
    [SerializeField] Transform m_NameInputField;

    private void OnEnable()
    {
        m_SaveTemplate.gameObject.SetActive(false);
        m_NameInputField.gameObject.SetActive(false);

        if (IsPlayerPrefHighScoreExist())
        {
            LoadHighScoreAndShowIt();
        }
        else if (WasInGame())
        {
            ItsANewHighScore = true; //Since there is no save and the game is done
        }

        if (ItsANewHighScore)
        {
            m_NameInputField.gameObject.SetActive(true);
        }
    }

    private void OnDisable()
    {
        DestroyAllClone();
    }

    public void AddToHighScore()
    {
        string TheName = m_NameInputField.transform.GetComponent<InputField>().text;

        SingleHighScore ANewHighScore = new SingleHighScore { Score = gamemanager.GetMyScore(), Name = TheName };

        HighScore MyHighScoreToLoad;

        if (IsPlayerPrefHighScoreExist())
        {
            string LoadHighScoreInJson = PlayerPrefs.GetString("AstHighScoreTable");
            MyHighScoreToLoad = JsonUtility.FromJson<HighScore>(LoadHighScoreInJson);

            MyHighScoreToLoad.HighScoreTableList.Add(ANewHighScore);

            SortTheHighScore(MyHighScoreToLoad);

            if (MyHighScoreToLoad.HighScoreTableList.Count > MaxSaveHighScore)
            {
                MyHighScoreToLoad.HighScoreTableList.RemoveAt(MaxSaveHighScore);
            }
        }
        else
        {
            MyHighScoreToLoad = new HighScore() { HighScoreTableList = new List<SingleHighScore> { ANewHighScore } };
        }

        HighScore MyHighScoreToSave = new HighScore { HighScoreTableList = MyHighScoreToLoad.HighScoreTableList };
        string SaveHighScoreInJson = JsonUtility.ToJson(MyHighScoreToSave);
        PlayerPrefs.SetString("AstHighScoreTable", SaveHighScoreInJson);
        PlayerPrefs.Save();

        m_NameInputField.gameObject.SetActive(false);

        DestroyAllClone();
        LoadHighScoreAndShowIt();
    }

    void CreateHighScoreTransform(SingleHighScore AHighScore, Transform Container, List<Transform> TheHighScoreTransformList)
    {
        if (WasInGame())
        {
            if (AHighScore.Score < gamemanager.GetMyScore() && TheHighScoreTransformList.Count < MaxSaveHighScore)
            {
                ItsANewHighScore = true;
            }
        }

        float TemplateHeight = 36f;
        Transform SaveTransform = Instantiate(m_SaveTemplate, Container, false);
        RectTransform SaveRectTransform = SaveTransform.GetComponent<RectTransform>();
        SaveRectTransform.anchoredPosition = new Vector2(0, -TemplateHeight * TheHighScoreTransformList.Count);
        SaveTransform.gameObject.SetActive(true);

        int Rank = TheHighScoreTransformList.Count + 1;
        SaveTransform.Find("PosTxt").GetComponent<Text>().text = Rank.ToString();

        SaveTransform.Find("ScoreTxt").GetComponent<Text>().text = AHighScore.Score.ToString();

        SaveTransform.Find("NomTxt").GetComponent<Text>().text = AHighScore.Name;

        TheHighScoreTransformList.Add(SaveTransform);
    }

    void SortTheHighScore(HighScore TheHighScoreToSort)
    {
        for (int i = 0; i < TheHighScoreToSort.HighScoreTableList.Count; i++)
        {
            for (int j = i + 1; j < TheHighScoreToSort.HighScoreTableList.Count; j++)
            {
                if (TheHighScoreToSort.HighScoreTableList[j].Score > TheHighScoreToSort.HighScoreTableList[i].Score)
                {
                    SingleHighScore TempToSwitch = TheHighScoreToSort.HighScoreTableList[i];
                    TheHighScoreToSort.HighScoreTableList[i] = TheHighScoreToSort.HighScoreTableList[j];
                    TheHighScoreToSort.HighScoreTableList[j] = TempToSwitch;
                }
            }
        }
    }

    bool WasInGame()
    {
        if (gamemanager.PlayerIsDead())
        {
            return true;
        }

        return false;
    }

    bool IsPlayerPrefHighScoreExist()
    {
        string LoadHighScoreInJson = PlayerPrefs.GetString("AstHighScoreTable");

        if (LoadHighScoreInJson != "")
        {
            return true;
        }

        return false;
    }

    void LoadHighScoreAndShowIt()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }

        string LoadHighScoreInJson = PlayerPrefs.GetString("AstHighScoreTable");
        HighScore MyHighScoreToLoad = JsonUtility.FromJson<HighScore>(LoadHighScoreInJson);

        m_HighScoreTransformList = new List<Transform>();

        foreach (SingleHighScore AHighScore in MyHighScoreToLoad.HighScoreTableList)
        {
            CreateHighScoreTransform(AHighScore, this.transform, m_HighScoreTransformList);
        }
    }

    void DestroyAllClone()
    {
        foreach (var line in m_HighScoreTransformList)
        {
            Destroy(line.gameObject);
        }

        m_HighScoreTransformList.Clear();
    }

    private class HighScore
    {
        public List<SingleHighScore> HighScoreTableList;
    }

    [System.Serializable]
    public class SingleHighScore
    {
        public int Score;
        public string Name;
    }
}