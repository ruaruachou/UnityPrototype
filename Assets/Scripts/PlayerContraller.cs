using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContraller : MonoBehaviour
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
        hor = Input.GetAxis("Horizontal");//ת��
        forwardInput = Input.GetAxis("Vertical");//����������������,������ֻ����ǰ��
        //���Ƴ���
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed*hor);

    }
}