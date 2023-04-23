using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MovementTypeManager : MonoBehaviour
{
    public SimpleCapsuleWithStickMovement simpleCapsuleWithStickMovement;
    public ContineousTurn contineousTurn;
    public TMP_Text movementNameText;

    public void ChangeMovementType()
    {
     
       if(simpleCapsuleWithStickMovement.enabled)
        {
            movementNameText.text = "Enable Snap Turn";
            simpleCapsuleWithStickMovement.enabled = false;
            contineousTurn.enabled = true;
        }
       else if (contineousTurn.enabled)
        {
            movementNameText.text = "Enable Continuous Turn";
            simpleCapsuleWithStickMovement.enabled = true;
            contineousTurn.enabled = false;
        }
    }
}
