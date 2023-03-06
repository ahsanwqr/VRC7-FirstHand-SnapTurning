using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class VerticalSnapTurn : MonoBehaviour
{
    public static VerticalSnapTurn Instance;
    private float angleToIncrement = 0;
    public int count = 0;
    public List<Snaps> snaps;
    public TMP_Text promtTex;
    public TMP_Text bttonText;
    private int snapIndex = 0;
    public int maximumNoOfSnaps;
    private void Start()
    {
        if (Instance == null)
            Instance = this;
        ChangeSnapAngle();
    }

    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstickDown))
        {
            if (count > 0 && angleToIncrement != 0)
            {
                count--;
                transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + angleToIncrement, transform.localEulerAngles.y, transform.localEulerAngles.z);
            }
        }
        else if (OVRInput.GetDown(OVRInput.Button.SecondaryThumbstickUp))
        {
            if (count < maximumNoOfSnaps && angleToIncrement != 0)
            {
                count++;
                transform.localEulerAngles = new Vector3(transform.localEulerAngles.x - angleToIncrement, transform.localEulerAngles.y, transform.localEulerAngles.z);
            }
        }

    }
    public void ChangeSnapAngle()
    {
        if (count == 0)
        {
            angleToIncrement = snaps[snapIndex].angle;
            this.maximumNoOfSnaps = snaps[snapIndex].maximumNoOfSnaps;
            snapIndex++;
            if (snapIndex >= snaps.Count)
            {
                snapIndex = 0;
            }
            promtTex.text = snaps[snapIndex].Name;
            bttonText.text = "Enable";
        }
    }

}
[System.Serializable]
public class Snaps
{
    public string Name;
    public int angle;
    public int maximumNoOfSnaps;
}