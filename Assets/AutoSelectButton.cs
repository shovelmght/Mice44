using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AutoSelectButton : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    [SerializeField] private InputField _FirstSelecableButton;
    [SerializeField] private CheckIfButtonIsSelect[] _ButtonsCanBeSelect;
    [SerializeField] private Button _SecondSelecableButton;
    [SerializeField] private Button _ConfirmButton;
    public NewActionInputManager playerInput;
    private bool InputFieldIsSelected;
    private bool Canselect;
    
    
    private void Awake()
    {
        GameObject reminder = GameObject.FindWithTag("Reminder");
        if (reminder != null)
        {
            ReminderPosPlayer reminderPosPlayer = reminder.GetComponent<ReminderPosPlayer>();

            if (reminderPosPlayer != null)
            {
                if (reminderPosPlayer._IsKeyboard)
                {
                    Debug.Log("AutoSelectButton is destroyed");
                    Destroy(this);
                }
            }
        }
        else
        {
            Debug.Log("Reminder tag game object is not found");
        }
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

    private int i;
    void Start()
    {
        foreach (var button in _ButtonsCanBeSelect)
        {
            
        }
        i++;
        Debug.Log("i = " + i );
      
        if (_FirstSelecableButton != null && _FirstSelecableButton.gameObject.activeInHierarchy)
        {
            _FirstSelecableButton.Select();
            _FirstSelecableButton.SetTextWithoutNotify("");
            
        }
        else if(_SecondSelecableButton != null && _SecondSelecableButton.gameObject.activeInHierarchy)
        {
            _SecondSelecableButton.Select();
        }
        
        playerInput.ArcadeMain1.Fire.canceled += _ => Fire();
    }


    private void Fire()
    {

        if (InputFieldIsSelected)
        {
            _ConfirmButton.Select();
        }
    }

    private bool _OneOfButtonIsSelected;
    private void Update()
    {
        bool oneIsSelected = false;
        foreach (var button in _ButtonsCanBeSelect)
        {
            if (button._IsSelected)
            {
                oneIsSelected = true;
                _OneOfButtonIsSelected = true;
                break;
            }
        }

        if (!oneIsSelected)
        {
            _OneOfButtonIsSelected = false;
        }
        InputFieldIsSelected = IsUIElementActive();
        float movementInput = playerInput.ArcadeMain1.MoveY.ReadValue<float>();
        if (movementInput > 0.5f || movementInput < -0.5f)
        {
            Debug.Log("InputFieldIsSelected = " + InputFieldIsSelected + "  Canselect = " + Canselect +"  _OtherButtonIsFocus = " + _OneOfButtonIsSelected);
            if (!InputFieldIsSelected && Canselect && !_OneOfButtonIsSelected)
            {
                _ConfirmButton.Select();
                Debug.Log(" _ConfirmButton.Select();");
            }
            
        }
    }

    IEnumerator SetCanControlSelact()
    {
        yield return new WaitForSeconds(0.1f);
        if (_FirstSelecableButton != null && _FirstSelecableButton.gameObject.activeInHierarchy)
        {
            _FirstSelecableButton.Select();
        }
        else if(_SecondSelecableButton != null && _SecondSelecableButton.gameObject.activeInHierarchy)
        {
            _SecondSelecableButton.Select();
        }
    }

    public  bool IsUIElementActive()
    {


        if (_FirstSelecableButton != null &&_FirstSelecableButton.isFocused)
        {
 
                //Debug.Log("true");
                return true;
            
        }
       // Debug.Log("false");
        return false;
    }


    public void OnSelect(BaseEventData eventData)
    {
        Canselect = false;

    }
    
    public void OnDeselect(BaseEventData eventData)
    {


        StartCoroutine(CanSelectDelay());
    }

    IEnumerator CanSelectDelay()
    {
        yield return new WaitForSeconds(1);
        
            Canselect = true;
        
    }
}
