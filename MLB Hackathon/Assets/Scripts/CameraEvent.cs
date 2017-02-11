using UnityEngine;
using System.Collections;

public class CameraEvent : GameEvent
{
    public string CameraName;

    public CameraEvent(float startEventTime, string cameraName)
    {
        eventTime = startEventTime;
        CameraName = cameraName;
    }
}
