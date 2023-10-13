using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreManager", menuName = "Score")]
public class ScoreManager : ScriptableObject
{

   [SerializeField]private int _Score;
   [SerializeField]private int _hIscore;
    public Action<int> OnUpdateScore;

    public void SethIscore(int newValue)
    {
        _hIscore = newValue;
    }
    
    public int GetIscore()
    {
       return  _hIscore;
    }
    
    public void SetScore(int newValue)
    {
        _Score = newValue;
    }

    public int GetScore()
    {
        return _Score;
    }
    
    
}
 