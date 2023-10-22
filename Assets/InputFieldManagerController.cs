using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManagerController : MonoBehaviour
{
    [SerializeField] private InputField _InputField;
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
                    _InputField.interactable = true;
                    Debug.Log("  _InputField.interactable = true;");

                }
            }
        }
        else
        {
            Debug.Log("Reminder tag game object is not found");
        }
  
    }
}
