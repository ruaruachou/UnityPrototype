using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContral : MonoBehaviour
{
    public Camera p1Camera1rd;
    public Camera p1Camera3rd;
    public Camera p2Camera1rd;
    public Camera p2Camera3rd;
    List<int> p1Camera = new List<int>();
    List<int> p2Camera = new List<int>();

    private void Start()
    {
        p1Camera1rd.enabled = false;
        p1Camera3rd.enabled = true;
        p2Camera1rd.enabled = false;
        p2Camera3rd.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {

        SwitchCameraState();
    }
    public void SwitchCameraState()//在不同相机之间切换
    {
        if (Input.GetMouseButtonDown(1))
        {

            p1Camera.Add(1);
            Debug.Log("P1ListIndex:" + p1Camera.Count);
            if (p1Camera.Count % 2 == 0)
            {
                p1Camera1rd.enabled = false;
                p1Camera3rd.enabled = true;
            }
            if (p1Camera.Count % 2 != 0)
            {
                p1Camera1rd.enabled = true;
                p1Camera3rd.enabled = false;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            p2Camera.Add(1);
            Debug.Log("P2ListIndex:"+p2Camera.Count);
            if (p2Camera.Count % 2 == 0)
            {
                p2Camera1rd.enabled = false;
                p2Camera3rd.enabled = true;
            }
            if (p2Camera.Count % 2 != 0)
            {
                p2Camera1rd.enabled = true;
                p2Camera3rd.enabled = false;
            }
        }
    }
}
