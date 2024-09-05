using System;
using UnityEngine;
public class Clock : MonoBehaviour
{
    const float hoursDegrees = -30f, minutesDegrees = -6f, secondsDegrees = -6f;


    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    // Start is called before the first frame update
    void Update() {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsDegrees * (float)time.TotalSeconds);
    }
}
