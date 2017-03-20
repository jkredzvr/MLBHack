# MLBHack
VR reliving past games

#DirectorScript : Monobehaviour
- Script that is used to sequentially Queue events to the EventManager to be played on start...
- EventManager.Instance.QueueEvent(new AudioEvent(0, "MrNovember-Commentary", new Vector3(0, 0, 0)));

#EventManager
- EventQueue that reads events (Player Event, Audio Event, Light Event, Camera Event)
- Must provide time in event is triggered

#GameEvent
- Base class for all events.  Just needs to have an float eventTime

#AudioManager.cs
- Exposes method to create audio and be played at a Vector3 location

#PlayerEvent.cs : GameEvent
- str PlayerName, AnimationState, Vector3 StartPos,EndPos, float yAngle...

Constructors for director actors by gameObject names @ startTime to 
- move from Start to End Pos
- animate

#LightEvent.cs : GameEvent
- str LightName, bool State
- enable/disable a light @ startTime by string name

#SoundEventListener
- Listens to AudioEvents and calls AudioManager to Play 

#AudioEvent.cs : GameEvent
- str Name, Vector3 Location
- Call an audio file by name to start playing at Location

#PlayerManager
- keeps dictionary of player/actor gameobject names: GameObject
- subscribes/listens to EventManager's OnPlayerEvent
- gets playerGameobject and change Animation or call SetMove(startPos,EndPos)

#PlayerBehaviour
- Set Move initialize startPos and endPos vector3 and isMoving true
- Update() check isMoving, and call Moving() script
- Moving() Lerps between start and end pos


#ActorAnimationController
- gets animatorcontroller
- exposes changeAnimation method that takes a animation string name and triggers the animator using a switch statement
