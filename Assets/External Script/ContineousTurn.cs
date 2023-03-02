using UnityEngine;

public class ContineousTurn : MonoBehaviour
{
    public GameObject OVRCameraRig;
    public float PlayerMovementSpeed;
    // Update is called once per frame
    void Update()
    {
        /* if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickRight))
         {
             gameObject.transform.Translate(Vector3.right * PlayerMovementSpeed * Time.deltaTime, Space.World);
         }

         if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickLeft))
         {
             gameObject.transform.Translate(Vector3.left * PlayerMovementSpeed * Time.deltaTime, Space.World);
         }*/

        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
        {
            transform.Rotate(Vector3.up * PlayerMovementSpeed * Time.deltaTime);
        }
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
        {
            transform.Rotate(Vector3.down * PlayerMovementSpeed * Time.deltaTime);
        }
    }
}
