using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemManagerWizard : MonoBehaviour
{

    [SerializeField]
    private GameObject firstMain;
    [SerializeField]
    private GameObject firstOptio;
    [SerializeField]
    private GameObject firstOption;
    [SerializeField]
    private GameObject firstCharacter;
    [SerializeField]
    private GameObject firstDifficulty;
    [SerializeField]
    private GameObject firstLanguage;
    [SerializeField]
    private GameObject firstCredit;
    [SerializeField]
    private EventSystem eventSystem;

    public void AddFirstMain()
    {
        eventSystem.SetSelectedGameObject(firstMain);
    }

    public void AddFirstOption()
    {
        eventSystem.SetSelectedGameObject(firstOptio);
    }

    public void AddFirstCharacter()
    {
        eventSystem.SetSelectedGameObject(firstCharacter);
    }


    public void AddFirstDifficulty()
    {
        eventSystem.SetSelectedGameObject(firstDifficulty);
    }

    public void AddFirstLanguage()
    {
        eventSystem.SetSelectedGameObject(firstLanguage);
    }

    public void AddFirstCredit()
    {
        eventSystem.SetSelectedGameObject(firstCredit);
    }

}
