using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    public Vector3 localGravity;
    private Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        rb.AddForce(localGravity, ForceMode.Acceleration);
    }
}
