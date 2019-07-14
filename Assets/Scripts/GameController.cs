using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public GameObject winnerLabelObject;
    public GameObject player2;
    public GameObject player2_Special;
    public float timeOut = 30; //[s]
    private float timeElapsed;


    public bool is_special { get; set; }


    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        if (count == 0)
        { //programwhengameplayerwins. 
            winnerLabelObject.SetActive(true);
        }

        if (is_special)
        {
            if (timeElapsed == 0)
            {
                changePlayer(player2, player2_Special);
            }
            // when is_specital is true,add timeElapse
            timeElapsed += Time.deltaTime;
            if (timeElapsed >= timeOut)
            {
                changePlayer(player2_Special, player2);
                is_special = false;
                timeElapsed = 0;
            }
        }

    }

    void changePlayer(GameObject deactobj, GameObject actobj)
    {
        deactobj.SetActive(false);
        actobj.SetActive(true);
        actobj.transform.position = deactobj.transform.position;
        actobj.transform.rotation = deactobj.transform.rotation;
    }

}
