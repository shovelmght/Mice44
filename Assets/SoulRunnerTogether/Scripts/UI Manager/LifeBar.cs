using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LesserKnown.Public;

public class LifeBar : MonoBehaviour
{
    public GameObject[] health_Bars;
    public bool is_player;
    public bool is_enemy;
    public int HP_Current;
    public int HP_Full;
    public bool reset;

    private void Start()
    {
        if (is_player)
            HP_Full = PublicVariables.HEALTH_FULL_PLAYER;
        if (is_enemy)
            HP_Full = PublicVariables.HEALTH_FULL_BOSS;
        HP_Current = HP_Full;
    }

    void Update()
    {
        reset = PublicVariables.IS_RESET;

        if (is_player)
            HP_Current = PublicVariables.hp_player;
        if(is_enemy)
            HP_Current = PublicVariables.hp_boss;

        if (HP_Full != HP_Current)
            HealthBars_Disabling();

        if (PublicVariables.IS_RESET)
            HealthBars_Reset();
    }

    public void HealthBars_Disabling() 
    {
        health_Bars[HP_Current].SetActive(false);

        if (HP_Current == 0)
        {
            HP_Current = HP_Full;
        }
    }
    public void HealthBars_Reset()
    {
        foreach(var bar in health_Bars)
            bar.SetActive(true);

        PublicVariables.IS_RESET = false;
        HP_Current = HP_Full;
    }
}
