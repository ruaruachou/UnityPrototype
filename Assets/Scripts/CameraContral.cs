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
        if (Input.GetMouseButtonDown(1)) 
        {
            p1Camera3rd.enabled=!
                p1Camera1rd.enabled=!
        }
    }
}
