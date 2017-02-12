using UnityEngine;
using System.Collections;

public class DirectorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        #region Actual Script
        //Play Sound
        //EventManager.Instance.QueueEvent(new CameraEvent(0, "PlayerCamera"));
        EventManager.Instance.QueueEvent(new AudioEvent(0, "MrNovember-Commentary", new Vector3(0, 0, 0)));
        EventManager.Instance.QueueEvent(new AudioEvent(0, "beforeHRAudienceCheer", new Vector3(0, 0, 0)));
        

        ///Player
        EventManager.Instance.QueueEvent(new PlayerEvent(2, "Jeter", "BatIdle"));


        //Play Sound
        EventManager.Instance.QueueEvent(new AudioEvent(3, "BooSFX", new Vector3(0, 0, 0)));
        //Play Sound
        EventManager.Instance.QueueEvent(new AudioEvent(5, "GoYankeesSFX", new Vector3(0, 0, 0)));
        //Play Sound
        EventManager.Instance.QueueEvent(new AudioEvent(6, "Boo2SFX", new Vector3(0, 0, 0)));
        //Play Sound
        EventManager.Instance.QueueEvent(new AudioEvent(8, "GoYankees2SFX", new Vector3(0, 0, 0)));
        //Play Sound
        EventManager.Instance.QueueEvent(new AudioEvent(9, "TrashTalkSFX", new Vector3(0, 0, 0)));

        EventManager.Instance.QueueEvent(new AudioEvent(10, "GoYankees2SFX", new Vector3(0, 0, 0)));


        //Pitcher Throw Animation
        EventManager.Instance.QueueEvent(new PlayerEvent(22, "Pitcher", "Throw"));


        //Pitcher Throw Animation
        EventManager.Instance.QueueEvent(new PlayerEvent(25, "Baseball", "BallHit"));

        ////Hitting The Ball
        EventManager.Instance.QueueEvent(new PlayerEvent(25, "Jeter", "Swing"));
        
        ////Hit Sound
        //EventManager.Instance.QueueEvent(new AudioEvent(25, "BatSFX", new Vector3(0, 0, 0)));
        EventManager.Instance.QueueEvent(new AudioEvent(26, "woodbat", new Vector3(0, 0, 0)));

        ////Run to first base
        EventManager.Instance.QueueEvent(new PlayerEvent(30, "Jeter", "Run"));
        EventManager.Instance.QueueEvent(new AudioEvent(30, "beforeHRAudienceCheer", new Vector3(0, 0, 0)));

        ////Run from first to second base
        EventManager.Instance.QueueEvent(new PlayerEvent(36, "Jeter", "Run", -370.844f));
        //EventManager.Instance.QueueEvent(new PlayerEvent(40, "Jeter", "Run", new Vector3(27, 0, 0), new Vector3(27, 0, 27)));

        ////Run from 2nd to 3rd base
        EventManager.Instance.QueueEvent(new PlayerEvent(42, "Jeter", "Run", -430.844f));

        //EventManager.Instance.QueueEvent(new PlayerEvent(50, "Jeter", "Run", new Vector3(27, 0, 27), new Vector3(0, 0, 27)));
        EventManager.Instance.QueueEvent(new AudioEvent(25, "JeterDefinMoment", new Vector3(0, 0, 0)));
        ////Run from 3rd to home base
        EventManager.Instance.QueueEvent(new PlayerEvent(47, "Jeter", "Run", -530.844f));
        //EventManager.Instance.QueueEvent(new PlayerEvent(60, "Jeter", "Run", new Vector3(0, 0, 27), new Vector3(0, 0, 0)));

        EventManager.Instance.QueueEvent(new PlayerEvent(47, "TeamMate1", "Run"));
        EventManager.Instance.QueueEvent(new PlayerEvent(47, "TeamMate2", "Run"));
        EventManager.Instance.QueueEvent(new PlayerEvent(47, "TeamMate3", "Run"));
        EventManager.Instance.QueueEvent(new PlayerEvent(47, "TeamMate4", "Run"));
        EventManager.Instance.QueueEvent(new PlayerEvent(47, "TeamMate5", "Run"));
        EventManager.Instance.QueueEvent(new PlayerEvent(47, "TeamMate6", "Run"));
        EventManager.Instance.QueueEvent(new PlayerEvent(47, "TeamMate7", "Run"));
        EventManager.Instance.QueueEvent(new PlayerEvent(47, "TeamMate8", "Run"));
        EventManager.Instance.QueueEvent(new PlayerEvent(47, "TeamMate9", "Run"));

        ////Celebrate with team
        EventManager.Instance.QueueEvent(new PlayerEvent(51, "TeamMate1", "Victory"));
        EventManager.Instance.QueueEvent(new PlayerEvent(51, "TeamMate2", "JumpVictory"));
        EventManager.Instance.QueueEvent(new PlayerEvent(51, "TeamMate3", "Victory"));
        EventManager.Instance.QueueEvent(new PlayerEvent(51, "TeamMate4", "JumpVictory"));
        EventManager.Instance.QueueEvent(new PlayerEvent(51, "TeamMate5", "JumpVictory"));
        EventManager.Instance.QueueEvent(new PlayerEvent(51, "TeamMate6", "Victory"));
        EventManager.Instance.QueueEvent(new PlayerEvent(51, "TeamMate9", "Victory"));
        EventManager.Instance.QueueEvent(new PlayerEvent(51, "TeamMate7", "JumpVictory"));
        EventManager.Instance.QueueEvent(new PlayerEvent(51, "TeamMate8", "JumpVictory"));
        EventManager.Instance.QueueEvent(new PlayerEvent(51, "Jeter", "Victory"));
        EventManager.Instance.QueueEvent(new PlayerEvent(54, "Jeter", "Idle"));


        ////Ball flying to the crowd
        //EventManager.Instance.QueueEvent(new PlayerEvent(27, "Ball", new Vector3(0, 0, 0), new Vector3(n, n, n)));


        ////Celebration with team
        //EventManager.Instance.QueueEvent(new PlayerEvent(42, "Team A Players", "celebrate", new Vector3(n, n, n));
        ////Fan lifts up a sign
        //EventManager.Instance.QueueEvent(new PlayerEvent(47, "Fan", "Lift Sign", new Vector3(n, n, n));
        #endregion

        #region JC Script
        ///JC Script
        //EventManager.Instance.QueueEvent(new AudioEvent(4, "BatSFX",new Vector3(0,0,0)));
        //EventManager.Instance.QueueEvent(new PlayerEvent(5, "Batter", "run", new Vector3(0, 0, 0), new Vector3(27, 0, 0)));
        ////Turn Light
        //EventManager.Instance.QueueEvent(new LightEvent(8, "LightA",true));
        //EventManager.Instance.QueueEvent(new LightEvent(9, "LightC", true));
        //EventManager.Instance.QueueEvent(new PlayerEvent(10, "Batter", "run", new Vector3(27, 0, 0), new Vector3(27, 0, 27)));
        //EventManager.Instance.QueueEvent(new CameraEvent(10, "PlayerCamera"));
        //EventManager.Instance.QueueEvent(new LightEvent(10, "LightB", true));
        //EventManager.Instance.QueueEvent(new LightEvent(11, "LightB", false));


        //EventManager.Instance.QueueEvent(new CameraEvent(14, "Main Camera"));

        #endregion




    }

    // Update is called once per frame
    void Update () {
        //if (Input.GetKeyDown(KeyCode.Alpha1)){
        //    Debug.Log("get input");
        //    AudioManager.instance.PlayNewSound("BatSFX", false, false, null, new Vector3(0,0,0));
        //}
	}
}
