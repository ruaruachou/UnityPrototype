using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContral : MonoBehaviour
{
    public Camera p1Camera1rd;
    public Camera p1Camera3rd;


    private void Start()
    {
        p1Camera1rd.enabled = false;
        p1Camera3rd.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        SwitchCameraState();
    }
    public void SwitchCameraState()
    {
        if (Input.GetMouseButtonDown(0))
        {
            p1Camera1rd.enabled = false;
            p1Camera3rd.enabled = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            p1Camera1rd.enabled = true;
            p1Camera3rd.enabled = false;
        }
    }
}
