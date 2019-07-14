using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpecialButton : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private Vector3 defaultPos;
    public GameObject hideItem;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }

    void OnCollisionEnter(Collision hit)
    {
        if (LayerMask.LayerToName(hit.gameObject.layer) == "SpecialPlayer")
        {
            rb.MovePosition(new Vector3(defaultPos.x, 0, defaultPos.z));
            hideItem.SetActive(true);
        }
    }
}

