using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

    public float speed = .1f;

    private Vector3 start;
    private Vector3 des;
    private float fraction = 0;
    bool isMoving = false;

    // Use this for initialization
    void Start () {
        start = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
        if (isMoving)
        {
            Moving();
        }
	}

    public void SetMove(Vector3 startPos, Vector3 endPos)
    {
        Debug.Log("StartPos:" + startPos);
        Debug.Log("EndPos:" + endPos);
        start = startPos;
        des = endPos;
        isMoving = true;
        
    }

    public void Moving()
    {
        if (fraction < 1)
        {
            fraction += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(start, des, fraction);
        }
        else
        {
            fraction = 0;
            isMoving = false;
        }
    }
}
