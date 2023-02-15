using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnInputManager : MonoBehaviour
{
    public SimpleCapsuleWithStickMovement SimpleCapsuleWithStick;
    public ContineousTurn contineousTurn;
    bool status;
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            ToggleTurn();
        }
    }

    private void ToggleTurn()
    {
        SimpleCapsuleWithStick.enabled = status;
    }
}
