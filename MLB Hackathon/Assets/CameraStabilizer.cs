using UnityEngine;
using System.Collections;

public class CameraStabilizer : MonoBehaviour {
    public Transform headPos;
    public Vector3 newHeadPos;
    public Vector3 curHeadPos;
    //public Vector3 curRot; public Vector3 deltaRot;

    // Use this for initialization
    void Start () {
        //curRot = transform.localEulerAngles;
        curHeadPos = transform.position;
}
	
	// Update is called once per frame
	void Update () {
        newHeadPos = headPos.position;
        this.transform.position = newHeadPos;
        
        
        //this.transform.position = new Vector3 (headPos.position.x, curHeadPos.y, headPos.position.z);

        //deltaRot = curRot - transform.localEulerAngles;
        //transform.localEulerAngles = curRot+deltaRot;

    }
}
