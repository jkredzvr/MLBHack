using UnityEngine;
using System.Collections;

public class DirectorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Play Sound
        EventManager.Instance.QueueEvent(new AudioEvent(2, "bat",new Vector3(0,0,0)));
        //Turn Light
        EventManager.Instance.QueueEvent(new AudioEvent(5, "hi asfddsaf"));
        //Move Model
        EventManager.Instance.QueueEvent(new PlayerEvent(10, "Batter","Run",new Vector3(0,0,0), new Vector3(0,0,27)));

    }

    // Update is called once per frame
    void Update () {
	
	}
}
