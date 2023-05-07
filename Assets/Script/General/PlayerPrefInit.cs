using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefInit : MonoBehaviour
{
    //if the playerpref are not initialized, it will set them to a default value for latter use.
    //this script should be present before the first scene that uses the playerprefs
    public string[] prefListScoreInt;
    public string[] prefListString;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < prefListScoreInt.Length; i++)
        {
            if (!PlayerPrefs.HasKey(prefListScoreInt[i]))
            {
                PlayerPrefs.SetFloat(prefListScoreInt[i], 0);
            }
        }

        for (int i = 0; i < prefListString.Length; i++)
        {
            if (!PlayerPrefs.HasKey(prefListString[i]))
            {
                PlayerPrefs.SetString(prefListString[i], "AAA");
            }
        }
    }

    
    public void ForceInit()
    {
        for (int i = 0; i < prefListScoreInt.Length; i++)
        {
            if (!PlayerPrefs.HasKey(prefListScoreInt[i]))
            {
                PlayerPrefs.SetFloat(prefListScoreInt[i], 0);
            }
        }

        for (int i = 0; i < prefListString.Length; i++)
        {
            if (!PlayerPrefs.HasKey(prefListString[i]))
            {
                PlayerPrefs.SetString(prefListString[i], "AAA");
            }
        }
    }

    public void ResetAllValues()
    {
        for (int i = 0; i < prefListScoreInt.Length; i++)
        {
            if (PlayerPrefs.HasKey(prefListScoreInt[i]))
            {
                PlayerPrefs.SetFloat(prefListScoreInt[i], 0);
            }
        }

        for (int i = 0; i < prefListString.Length; i++)
        {
            if (PlayerPrefs.HasKey(prefListString[i]))
            {
                PlayerPrefs.SetString(prefListString[i], "AAA");
            }
        }
    }

    public void ResetStringValues()
    {

        for (int i = 0; i < prefListString.Length; i++)
        {
            if (PlayerPrefs.HasKey(prefListString[i]))
            {
                PlayerPrefs.SetString(prefListString[i], "AAA");
            }
        }
    }

    public void ResetFloatValues()
    {
        for (int i = 0; i < prefListScoreInt.Length; i++)
        {
            if (PlayerPrefs.HasKey(prefListScoreInt[i]))
            {
                PlayerPrefs.SetFloat(prefListScoreInt[i], 0);
            }
        }
    }
}
