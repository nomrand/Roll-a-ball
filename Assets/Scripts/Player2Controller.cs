using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 500;
    public float turnSpeed = 10;
    public float jumpPower = 10;
    public bool OnGround { get; set; }

    public Vector3 xyz;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        OnGround = false;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Transform transform = GetComponent<Transform>();
        ParticleSystem footSmoke = GetComponent<ParticleSystem>();

        xyz = rigidbody.velocity;
        if (x == 0 && z == 0)
        {
            rigidbody.velocity = new Vector3(0, rigidbody.velocity.y, 0);
            rigidbody.angularVelocity = Vector3.zero;
            animator.SetBool("is_walk", false);
            footSmoke.Stop();

        }
        else
        { // Add physical force to theplayer 
            rigidbody.AddForce(x * moveSpeed, 0, z * moveSpeed);
            // Change the directionof theplayer
            float degree = 90 - (Mathf.Atan2(z, x) * 180 / Mathf.PI);
            Quaternion dest_quat = Quaternion.Euler(0, degree, 0);
            Quaternion curr_quat = transform.rotation;
            transform.rotation = Quaternion.RotateTowards(curr_quat, dest_quat, turnSpeed);
            animator.SetBool("is_walk", true);
            if (OnGround)
            {
                footSmoke.Play();
            }

        }
        // when player in air, particle not occur
        if (!OnGround)
        {
            footSmoke.Stop();
        }

        // When input spaceKey, player jump
        if (Input.GetButtonDown("Jump") && OnGround)
        {
            rigidbody.velocity = transform.up * jumpPower;
            OnGround = false;

        }

    }
}
