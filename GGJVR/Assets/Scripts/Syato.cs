// Created by:      Gabriel Hansley Suarez
// Date Created:    January 26, 2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syato : MonoBehaviour {

    private GameObject gamemanager;
    private static bool syatoMGR;
    private static bool interactable;
    int stickcounter = 0;

	// Use this for initialization
	void Start () {
        gamemanager = GameObject.FindGameObjectWithTag("manager");
        syatoMGR = gamemanager.GetComponent<GameManager_Syato>().hasStick;
        interactable = true;
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            syatoMGR = false;
            interactable = false;
        }

        if (collision.gameObject.CompareTag("player_stick") && interactable == true)
        {
            stickcounter += 1;

            this.gameObject.GetComponent<Rigidbody>().useGravity = true;

            if (stickcounter > 1)
                gamemanager.GetComponent<GameManager_Syato>().score += 1;
            
        }
    }
}
