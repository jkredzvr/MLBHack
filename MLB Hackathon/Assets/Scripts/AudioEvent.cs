using UnityEngine;
using System.Collections;

public class AudioEvent : GameEvent {

    public string Name;

    public AudioEvent(float startEventTime, string name)
    {
        eventTime = startEventTime;
        Name = name;
    }
}
