using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 defaultPos;
    public float speedrate = 5;
    public float moveheight = 20;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }
    void FixedUpdate()
    {
        rb.MovePosition(new Vector3(defaultPos.x, defaultPos.y + Mathf.PingPong(speedrate * Time.time, moveheight), defaultPos.z));
    }
}
