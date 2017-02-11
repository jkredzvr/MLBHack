using UnityEngine;
using System.Collections;

public class DirectorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Play Sound
        EventManager.Instance.QueueEvent(new AudioEvent(0, "MrNovember-Commentary", new Vector3(0, 0, 0))); 
        EventManager.Instance.QueueEvent(new AudioEvent(4, "BatSFX",new Vector3(0,0,0)));
        //Turn Light
        EventManager.Instance.QueueEvent(new LightEvent(8, "LightA",true));
        EventManager.Instance.QueueEvent(new LightEvent(9, "LightC", true));
        EventManager.Instance.QueueEvent(new CameraEvent(9, "PlayerCamera"));
        EventManager.Instance.QueueEvent(new LightEvent(10, "LightB", true));
        EventManager.Instance.QueueEvent(new LightEvent(11, "LightB", false));
        EventManager.Instance.QueueEvent(new CameraEvent(14, "Main Camera"));
        //Move Model
        //EventManager.Instance.QueueEvent(new PlayerEvent(10, "Batter","Run",new Vector3(0,0,0), new Vector3(0,0,27)));




        //EventManager.Instance.QueueEvent(new AudioEvent(1, "Commentary", new Vector3(n, n, n)));
        ////Play Lifting Up Bat Animation
        //EventManager.Instance.QueueEvent(new PlayerEvent(20, "Batter", "Lift Bat", new Vector3(0, 0, 0)));
        ////Hitting The Ball
        //EventManager.Instance.QueueEvent(new PlayerEvent(25, "Batter", "Hit Ball", new Vector3(0, 0, 0)));
        ////Hit Sound
        //EventManager.Instance.QueueEvent(new AudioEvent(25, "Hit", new Vector3(0, 0, 0)));

        ////Ball flying to the crowd
        //EventManager.Instance.QueueEvent(new PlayerEvent(27, "Ball", new Vector3(0, 0, 0), new Vector3(n, n, n)));
        ////Player lifts up arm (celebratory) while running
        //EventManager.Instance.QueueEvent(new PlayerEvent(32, "Batter", "Lift Arm"), new Vector3(n, n, n));
        ////Celebration with team
        //EventManager.Instance.QueueEvent(new PlayerEvent(42, "Team A Players", "celebrate", new Vector3(n, n, n));
        ////Fan lifts up a sign
        //EventManager.Instance.QueueEvent(new PlayerEvent(47, "Fan", "Lift Sign", new Vector3(n, n, n));
    }

    // Update is called once per frame
    void Update () {
        //if (Input.GetKeyDown(KeyCode.Alpha1)){
        //    Debug.Log("get input");
        //    AudioManager.instance.PlayNewSound("BatSFX", false, false, null, new Vector3(0,0,0));
        //}
	}
}
