using UnityEngine;
using System.Collections;

public class AudioEvent : GameEvent {

    public string Name;
    public Vector3 Location;

    public AudioEvent(float startEventTime, string name, Vector3 location)
    {
        eventTime = startEventTime;
        Name = name;
        Location = location;
    }
}
