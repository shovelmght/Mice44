using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AutoSelectButton : MonoBehaviour
{
    [SerializeField] private GameObject GameObject;
    [SerializeField] private InputField _FirstSelecableButton;
    [SerializeField] private Button _SecondSelecableButton;
    [SerializeField] private Button _ConfirmButton;
    private NewActionInputManager playerInput;
    private bool InputFieldIsSelected;
    private bool Canselect;
    
    
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

    private int i;
    void Start()
    {
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

        if (InputFieldIsSelected || Canselect)
        {
            _ConfirmButton.Select();
        }
    }

    private void Update()
    {
        InputFieldIsSelected = IsUIElementActive();
        /*float movementInput = playerInput.ArcadeMain1.MoveY.ReadValue<float>();
        if (movementInput > 0.5f || movementInput < -0.5f)
        {
            if (InputFieldIsSelected || Canselect)
            {
                _ConfirmButton.Select();
            }
        }*/
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
        if (_FirstSelecableButton.isFocused)
        {
 
                Debug.Log("true");
                return true;
            
        }
        Debug.Log("false");
        return false;
    }


}
