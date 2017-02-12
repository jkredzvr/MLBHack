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

        //Just animation event
        if (e.StartPos == Vector3.zero && e.EndPos == Vector3.zero)
        {
            if(e.yAngle != 0)
            {
                try
                {
                    player.GetComponent<ActorAnimationController>().changeAnimation(e.AnimationState);
                    player.transform.localEulerAngles = new Vector3(player.transform.localEulerAngles.x, e.yAngle, player.transform.localEulerAngles.z);

                }
                catch
                {
                    Debug.Log("Couldnt find animation" + e.AnimationState);
                }
            }

            Debug.Log(e.AnimationState);
            try
            {
                player.GetComponent<ActorAnimationController>().changeAnimation(e.AnimationState);
            }
            catch
            {
                Debug.Log("Couldnt find animation" + e.AnimationState);
            }
        }
        else
        {
            player.GetComponent<PlayerBehaviour>().SetMove(e.StartPos, e.EndPos);
            Debug.Log(e.AnimationState);
            try
            {
                player.GetComponent<ActorAnimationController>().changeAnimation(e.AnimationState);
            }
            catch
            {
                Debug.Log("Couldnt find animation" + e.AnimationState);
            }
        }
    }

    public GameObject FindPlayerGameObject(string playerName)
    {
        GameObject player = playerDictionary[playerName];
        return player;
    }
}
