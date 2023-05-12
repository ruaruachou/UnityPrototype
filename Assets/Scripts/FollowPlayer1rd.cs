using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer1rd : MonoBehaviour
{
    public GameObject player1rd;
    private Vector3 offset1 = new Vector3(0, 3, 1);

    void Update()
    {
        transform.position = player1rd.transform.position+offset1;
    }
}
