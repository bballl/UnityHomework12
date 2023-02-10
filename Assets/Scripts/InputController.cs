using UnityEngine;

/// <summary>
/// Контроллер управления.
/// </summary>
internal class InputController
{
    public float GetHorizontal()
    {
        return Input.GetAxis("Horizontal");
    }

    public float GetVertical()
    {
        return Input.GetAxis("Vertical");
    }

    public bool GetJumpButton()
    {
        var jumpButton = Input.GetAxis("Jump");

        if (jumpButton > 0)
        {
            return true;
        }
        else 
            return false;
    }
    public bool IsActivateButtonPressed()
    {
        if (Input.GetKey(KeyCode.E))
            return true;
        return false;
    }
}