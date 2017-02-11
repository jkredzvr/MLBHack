using UnityEngine;
using System.Collections;

public class DirectorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        #region Actual Script
        //Play Sound
        EventManager.Instance.QueueEvent(new AudioEvent(0, "MrNovember-Commentary", new Vector3(0, 0, 0)));

        //Play Lifting Up Bat Animation
        EventManager.Instance.QueueEvent(new PlayerEvent(20, "Batter", "Lift Bat"));

        EventManager.Instance.QueueEvent(new CameraEvent(21, "PlayerCamera"));

        //Pitcher Throw Animation
        EventManager.Instance.QueueEvent(new PlayerEvent(22, "Pitcher", "Throw"));

       


        //Pitcher Throw Animation
        EventManager.Instance.QueueEvent(new PlayerEvent(23, "Baseball", "Spin", new Vector3(27/2f,0,27/2f), new Vector3(0,0,0)));

        ////Hitting The Ball
        EventManager.Instance.QueueEvent(new PlayerEvent(25, "Batter", "Swing"));
        
        ////Hit Sound
        EventManager.Instance.QueueEvent(new AudioEvent(25, "BatSFX", new Vector3(0, 0, 0)));

        ////Run to first base
        EventManager.Instance.QueueEvent(new PlayerEvent(26, "Batter", "Run", new Vector3(0, 0, 0), new Vector3(27, 0, 0)));

        ////Run from first to second base
        EventManager.Instance.QueueEvent(new PlayerEvent(35, "Batter", "Run", new Vector3(27, 0, 0), new Vector3(27, 0, 27)));

        ////Player lifts up arm (celebratory) while running
        EventManager.Instance.QueueEvent(new PlayerEvent(32, "Batter", "Lift Arm"));

        ////Run from 2nd to 3rd base
        EventManager.Instance.QueueEvent(new PlayerEvent(40, "Batter", "Run", new Vector3(27, 0, 27), new Vector3(0, 0, 27)));

        ////Run from 3rd to home base
        EventManager.Instance.QueueEvent(new PlayerEvent(45, "Batter", "Run", new Vector3(0, 0, 27), new Vector3(0, 0, 0)));

        ////Celebrate with team
        EventManager.Instance.QueueEvent(new PlayerEvent(50, "Batter", "Celebrate"));


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
