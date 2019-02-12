// Created by:      Gabriel Hansley Suarez
// Date Created:    January 26, 2019

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager_tumba : MonoBehaviour {

    // Can properties
    public GameObject can;
    private Transform canPosition;
    public bool activeCan = true;

    private GameObject curCans;
    public int curCanPts;

    public int score = 0;

    private static int slipperCount = 5;

    public Text scoreText;
    public Text countdownEnd;

    private float countdownTime = 5f;

    private AudioSource audiosrc;
    public AudioClip[] audioClips;

    public GameObject countdownEndContainer;

    // Use this for initialization
    void Start()
    {
        can.transform.rotation = Quaternion.identity;
        can.transform.position = new Vector3(UnityEngine.Random.Range(-2.3f, 2.6f), 0.27f, UnityEngine.Random.Range(5.6f, 6.0f));
        Instantiate(can);

        scoreText.text = score.ToString();

        audiosrc = GetComponent<AudioSource>();
        playAudio(0);
    }

    // Update is called once per frame
    void Update () {

        if (GameObject.FindGameObjectsWithTag("slippers").Length > 0)
        {
            if (activeCan == false)
            {
                can.transform.rotation = Quaternion.identity;
                can.transform.position = new Vector3(UnityEngine.Random.Range(-2.3f, 2.6f), 0.6f, UnityEngine.Random.Range(5.6f, 6.0f));
                Instantiate(can);
                slipperCount -= 1;
                activeCan = true;
            }
        }
        else
        {
            countdownTime -= Time.deltaTime * 1;
            countdownEnd.text = countdownTime.ToString("n2");
            countdownTime = Mathf.Clamp(countdownTime, 0, 5f);

            if (countdownTime <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }

        scoreText.text = score.ToString();
    }

    // Current can point calculation
    public void FindCurrentCan()
    {
        curCans = GameObject.Find("cans(clone)");

        curCanPts = (int)((Math.Abs(curCans.transform.position.x) + Math.Abs(curCans.transform.position.y) + Math.Abs(curCans.transform.position.z)));
    }

    // Play audio
    void playAudio(int x)
    {
        audiosrc.clip = audioClips[x]; // play corresponding audio clip
        audiosrc.Play(); // Audio source attached to the player
    }
}
