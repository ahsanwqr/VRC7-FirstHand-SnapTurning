using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContineousTurn : MonoBehaviour
{
    public GameObject OVRCameraRig;
    public float PlayerMovementSpeed;
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickRight))
        {
            gameObject.transform.Translate(Vector3.forward * PlayerMovementSpeed * Time.deltaTime, Space.World);
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickLeft))
        {
            gameObject.transform.Translate(Vector3.back * PlayerMovementSpeed * Time.deltaTime, Space.World);
        }
    }
}
