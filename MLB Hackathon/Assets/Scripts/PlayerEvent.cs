using UnityEngine;
using System.Collections;

public class PlayerEvent : GameEvent
{

    public string PlayerName;
    public string AnimationState;
    public Vector3 StartPos;
    public Vector3 EndPos;
    public float yAngle;

    public PlayerEvent(float startEventTime, string playerName, string animationState, Vector3 startPos, Vector3 endPos)
    {
        eventTime = startEventTime;
        PlayerName = playerName;
        AnimationState = animationState;
        StartPos = startPos;
        EndPos = endPos;
    }

    public PlayerEvent(float startEventTime, string playerName, string animationState)
    {
        eventTime = startEventTime;
        PlayerName = playerName;
        AnimationState = animationState;
    }

    public PlayerEvent(float startEventTime, string playerName, string animationState, float angle)
    {
        eventTime = startEventTime;
        PlayerName = playerName;
        AnimationState = animationState;
        yAngle = angle;
    }

}
