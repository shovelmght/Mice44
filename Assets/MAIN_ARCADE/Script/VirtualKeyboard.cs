using System;
using UnityEngine;
using UnityEngine.UI;

public class VirtualKeyboard : MonoBehaviour
{
    [SerializeField] private InputField _InputField;

    private string _CurrentText = "";

    private void Awake()
    {
        GameObject reminder = GameObject.FindWithTag("Reminder");
        if (reminder != null)
        {
            ReminderPosPlayer reminderPosPlayer = reminder.GetComponent<ReminderPosPlayer>();

            if (reminderPosPlayer == null) return;
            if (reminderPosPlayer._IsKeyboard)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            Debug.Log("Reminder tag game object is not found");
        }
    }

    //Called by button
    public void SetText(string textToAdd)
    {
        _CurrentText += textToAdd;
        _InputField.text = _CurrentText;
    }
    
    //Called by button
    public void BackSpaceText()
    {
        _CurrentText.Remove(_CurrentText.Length - 1);
        _InputField.text = _CurrentText;
    }
}
