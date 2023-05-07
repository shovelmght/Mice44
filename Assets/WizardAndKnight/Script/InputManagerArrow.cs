using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerArrow : InputManagerWizardAndKnight
{
    private bool DisableInput;

    //  Move right  with arrow
    override public bool WantsMoveRight()     
    {
        if (Input.GetKey(KeyCode.RightArrow) && !DisableInput)
        {
            return true;
        }
        return false;
    }

    //  Move Left with arrow
    override public bool WantsMoveLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && !DisableInput)    
        {
            Debug.Log("ss");
            return true;
        }
        return false;
    }


}
