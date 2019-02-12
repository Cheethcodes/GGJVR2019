// Created by:      Gabriel Hansley Suarez
// Date Created:    January 26, 2019

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TumbangPreso : MonoBehaviour {

    public GameObject GameManager;
    private GameManager_tumba tumbaMGR;

    private GameObject curCans;
    
    private static int score;

    private void Start()
    {
        tumbaMGR = GameManager.GetComponent<GameManager_tumba>();
    }

    // Update is called once per frame
    void Update () {

        if (GameObject.FindGameObjectsWithTag("cans").Length >= 1)
        {
            curCans = GameObject.FindGameObjectWithTag("cans");
            score = (int)((Math.Abs(curCans.transform.position.x) + Math.Abs(curCans.transform.position.y) + Math.Abs(curCans.transform.position.z)));
        }

	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("cans"))
        {
            tumbaMGR.activeCan = false;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            tumbaMGR.score += tumbaMGR.curCanPts;
        }
    }
}
