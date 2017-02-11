using UnityEngine;
using System.Collections;

public class LightEvent : GameEvent
{

    public string LightName;
    public bool State;

    public LightEvent(float startEventTime, string lightName, bool state)
    {
        LightName = lightName;
        eventTime = startEventTime;
        State = state;
    }
}

