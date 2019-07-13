using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    void FixedUpdate()
    { // substitution‘input’intoxandz
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //acquireRigidbodycomponentwhichsameGameobject owned
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(x * speed, 0, z * speed);

    }
}
