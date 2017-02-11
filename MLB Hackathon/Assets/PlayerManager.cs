using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour {

    public List<GameObject> playerList = new List<GameObject>();
    public Dictionary<string, GameObject> playerDictionary = new Dictionary<string, GameObject>();


	// Use this for initialization
	void Start () {
        //Set up playerDictionary
	    foreach(GameObject player in playerList)
        {
            playerDictionary.Add(player.name, player);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEnable()
    {
        EventManager.Instance.AddListener<PlayerEvent>(OnPlayerEvent);
    }

    void OnDisable()
    {
        EventManager.Instance.RemoveListener<PlayerEvent>(OnPlayerEvent);
    }

    void OnPlayerEvent(PlayerEvent e)
    {
        GameObject player = playerDictionary[e.PlayerName];
        Debug.Log("<color=red>Event Time:</color>" + e.eventTime);
        Debug.Log("<color=red>Animation:</color>" + e.AnimationState);
        player.GetComponent<PlayerBehaviour>().Move(e.StartPos, e.EndPos);

        //Debug.Log("<color=red>Audio Event happened</color>" + e.Name);
    }

    public GameObject FindPlayerGameObject(string playerName)
    {
        GameObject player = playerDictionary[playerName];
        return player;
    }
}
