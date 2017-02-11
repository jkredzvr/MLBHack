using UnityEngine;
using System.Collections;

public class FakeSoundEventListener : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //EventManager.Instance.QueueEvent(new AudioEvent(1, "yea"));
        //EventManager.Instance.QueueEvent(new AudioEvent(5, "hi asfddsaf"));
        //EventManager.Instance.QueueEvent(new AudioEvent(10,"heyo"));
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnEnable()
    {
        EventManager.Instance.AddListener<AudioEvent>(OnAudioEvent);
    }
    void OnDisable()
    {
        EventManager.Instance.RemoveListener<AudioEvent>(OnAudioEvent);
    }

    void OnAudioEvent(AudioEvent e)
    {
        Debug.Log("<color=red>Audio Event happened</color>" + e.Name);
    }
}
