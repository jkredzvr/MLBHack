using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LightManager : MonoBehaviour
{

    public List<GameObject> lightList = new List<GameObject>();
    public Dictionary<string, GameObject> lightDictionary = new Dictionary<string, GameObject>();


    // Use this for initialization
    void Start()
    {
        //Set up playerDictionary
        foreach (GameObject player in lightList)
        {
            lightDictionary.Add(player.name, player);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        EventManager.Instance.AddListener<LightEvent>(OnLightEvent);
    }

    void OnDisable()
    {
        EventManager.Instance.RemoveListener<LightEvent>(OnLightEvent);
    }

    void OnLightEvent(LightEvent e)
    {
        GameObject light = lightDictionary[e.LightName];
        if (e.State == true)
        {
            //turn light on
            if (light.GetComponent<Light>().enabled)
            {
                Debug.Log("Light alreaddy on");
                return;
            }
            else { light.GetComponent<Light>().enabled = true;  }
        }
        else
        {
            //turn light off
            if (!light.GetComponent<Light>().enabled)
            {
                Debug.Log("Light alreaddy off");
                return;
            }
            else { light.GetComponent<Light>().enabled = false; }
        }
       

        //Debug.Log("<color=red>Audio Event happened</color>" + e.Name);
    }

    //public GameObject FindPlayerGameObject(string playerName)
    //{
    //    GameObject player = playerDictionary[playerName];
    //    return player;
    //}
}
