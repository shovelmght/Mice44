using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerWizardAndKnight
{
    private bool DisableInput;

    //  Move right / D
    virtual public bool WantsMoveRight()   
    {
        if (Input.GetKey(KeyCode.D) && !DisableInput)
        {
            return true;
        }
        return false;
    }

    //  Move Left / A
    virtual public bool WantsMoveLeft()
    {
        if (Input.GetKey(KeyCode.A) && !DisableInput)    
        {
            return true;
        }
        return false;
    }

    // Jump / space
    virtual public bool Jump() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && !DisableInput)
        {
            return true;
        }
        return false;
    }

    //  Shoot projectil / F /Left clic mouse
    virtual public bool ShootProjectil()   
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.F) && !DisableInput)
        {
            return true;
        }
        return false;
    }


    //Action button /  W
    virtual public bool EnterCave()
    {
        if (Input.GetKeyDown(KeyCode.W) && !DisableInput)    
        {
            return true;
        }
        return false;
    }

    //Restanrt the game / R
    virtual public bool Restart()
    {
        if (Input.GetKeyDown(KeyCode.R))   
        {
            return true;
        }
        return false;
    }


    //Sette disable input bool
    virtual public void SetDisableInput(bool onOff)
    {
        DisableInput = onOff;
    }
}
