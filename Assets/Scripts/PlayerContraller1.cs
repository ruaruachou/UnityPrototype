using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContraller1 : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed=10f;
    public float hor;
    public float forwardInput;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal1");//转向
        forwardInput = Input.GetAxis("Vertical1");//如果不加入这个变量,车辆就只会往前走
        //控制车辆
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed*hor);

    }
}
