using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AutoSelectButton : MonoBehaviour
{
    [SerializeField] private InputField _FirstSelecableButton;
    [SerializeField] private Button _SecondSelecableButton;
    [SerializeField] private Button _ConfirmButton;
    private NewActionInputManager playerInput;
    private bool InputFieldIsSelected;
    
    
    private void Awake()
    {
        playerInput = new NewActionInputManager();
    }

    public void OnEnable()
    {
        playerInput.Enable();
    }
    public void OnDisable()
    {
        playerInput.Disable();
    }
    void Start()
    {
        if (_FirstSelecableButton.gameObject.activeInHierarchy)
        {
            _FirstSelecableButton.Select();
        }
        else if(_SecondSelecableButton.gameObject.activeInHierarchy)
        {
            _SecondSelecableButton.Select();
        }
        
        playerInput.ArcadeMain.Fire.performed += _ => Fire();
    }


    private void Fire()
    {
        if (InputFieldIsSelected)
        {
            _ConfirmButton.Select();
        }
       
    }

    private void Update()
    {
        InputFieldIsSelected = IsUIElementActive();
    }

    public static bool IsUIElementActive()
    {
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            InputField IF = EventSystem.current.currentSelectedGameObject.GetComponent<UnityEngine.UI.InputField>();
            if (IF != null)
            {
                
        
                return true;
            }
        }

        return false;
    }
}
