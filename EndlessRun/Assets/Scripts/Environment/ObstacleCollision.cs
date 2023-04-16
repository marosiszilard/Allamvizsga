using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject player;
    public GameObject charModel;
    public AudioSource charsThud;
    public GameObject mainCam;
    public GameObject levelControl;
   

    // Utkozes a targyakkal
    private void OnTriggerEnter(Collider other)
    {

        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMove>().enabled = false;
        //
        charModel.GetComponent<Animator>().Play("Sword And Shield Death");
        levelControl.GetComponent<LevelDistance>().enabled = false; 
        charsThud.Play();
        mainCam.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }

}
