using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraManager : MonoBehaviour
{

    public List<Camera> cameraList = new List<Camera>();
    public Dictionary<string, Camera> cameraDictionary = new Dictionary<string, Camera>();
    public Camera ActiveCamera;

    // Use this for initialization
    void Start()
    {
        
        //Set up playerDictionary
        foreach (Camera camera in cameraList)
        {
            cameraDictionary.Add(camera.name, camera);
        }
        ActiveCamera = cameraDictionary["Camera (head)"];
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        EventManager.Instance.AddListener<CameraEvent>(OnCameraEvent);
    }

    void OnDisable()
    {
        EventManager.Instance.RemoveListener<CameraEvent>(OnCameraEvent);
    }

    void OnCameraEvent(CameraEvent e)
    {
        Camera camera = cameraDictionary[e.CameraName];
        ActiveCamera.enabled = false;
        ActiveCamera = camera;
        ActiveCamera.enabled = true;


        //Debug.Log("<color=red>Audio Event happened</color>" + e.Name);
    }
}
