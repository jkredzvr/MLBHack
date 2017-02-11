using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Move(Vector3 startPos, Vector3 endPos)
    {
        Debug.Log("StartPos:" + startPos);
        Debug.Log("EndPos:" + endPos);
    }
}
