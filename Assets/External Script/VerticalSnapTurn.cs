using UnityEngine;

public class VerticalSnapTurn : MonoBehaviour
{

    [SerializeField] private float angleToIncrement = 45f;
    private int count = 0;

    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstickDown))
        {
            if (count > 0)
            {
                count--;
                transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + angleToIncrement, transform.localEulerAngles.y, transform.localEulerAngles.z);
            }
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstickUp))
        {
            if (count < 2)
            {
                count++;
                transform.localEulerAngles = new Vector3(transform.localEulerAngles.x - angleToIncrement, transform.localEulerAngles.y, transform.localEulerAngles.z);
            }
        }

    }



}
