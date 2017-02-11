using UnityEngine;
using System.Collections;

public class PlayerEvent : GameEvent
{

    public string PlayerName;
    public string AnimationState;
    public Vector3 StartPos;
    public Vector3 EndPos;

    public PlayerEvent(float startEventTime, string playerName, string animationState, Vector3 startPos, Vector3 endPos)
    {
        eventTime = startEventTime;
        AnimationState = animationState;
        StartPos = startPos;
        EndPos = endPos;
    }
}
