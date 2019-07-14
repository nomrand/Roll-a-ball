using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target; //Referencetotarget 
    private Vector3 offset; //relativedistance 

    // Start is called before the first frame update
    void Start()
    {
        //Getrelativedistancebetween“Player”and“MainCamera”
        offset = GetComponent<Transform>().position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = target.transform.position + offset;
        // When target is deactivate, switch follow another activate player.
        if (!target.activeSelf)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }

    }
}
