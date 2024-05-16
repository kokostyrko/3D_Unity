using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject player;
    public GameObject charModel;
    public AudioSource crashThud;
    public Camera mainCamera;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<Move>().enabled = false;

        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crashThud.Play();

        mainCamera.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunSequence>().enabled=true;
    }
}
