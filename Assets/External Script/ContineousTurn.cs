using UnityEngine;

public class ContineousTurn : MonoBehaviour
{
    public GameObject OVRCameraRig;
    public float PlayerMovementSpeed;
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
        {
            transform.Rotate(Vector3.up * PlayerMovementSpeed * Time.deltaTime);
        }
       else if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
        {
            transform.Rotate(Vector3.down * PlayerMovementSpeed * Time.deltaTime);
        }
    }
}
