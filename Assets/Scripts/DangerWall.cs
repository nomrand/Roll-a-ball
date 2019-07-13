using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour
{
    //Thecall-backofcontacttrigger
    void OnCollisionEnter(Collision hit)
    {
        //WhenPlayercontact“DangerWall”
        if (hit.gameObject.CompareTag("Player"))
        {
            //Getsceneindex 
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            //Reloadscene
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
