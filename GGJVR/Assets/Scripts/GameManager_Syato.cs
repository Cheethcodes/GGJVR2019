// Created by:      Gabriel Hansley Suarez
// Date Created:    January 26, 2019

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager_Syato : MonoBehaviour {

    public GameObject stick;
    public bool hasStick = false;
    public int score = 0;
    private float time = 10f;
    private Text timecontainer;
    private Text scorecontainer;
    public GameObject countdownEndContainer;
    public Text countdownEnd;
    private float countdownTime = 5f;

    private AudioSource audiosrc;
    public AudioClip[] audioClips;

    // Use this for initialization
    void Start () {
        timecontainer = GameObject.Find("TimeDisplay").GetComponent<Text>();
        scorecontainer = GameObject.Find("stick count").GetComponent<Text>();

        Instantiate(stick);
        hasStick = true;

        timecontainer.text = time.ToString("n2");
        scorecontainer.text = score.ToString();

        audiosrc = GetComponent<AudioSource>();
        playAudio(0);
    }
	
	// Update is called once per frame
	void Update () {

        if (time > 0)
        {
            time -= Time.deltaTime * 1;
            time = Mathf.Clamp(time, 0, 30f);

            if (hasStick == false)
            {
                Instantiate(stick);
                hasStick = true;
            }
        }
        else
        {
            countdownTime -= Time.deltaTime * 1;
            countdownEndContainer.SetActive(true);
            countdownTime = Mathf.Clamp(countdownTime, 0, 5f);
            countdownEnd.text = countdownTime.ToString("n2");

            if (countdownTime <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }

        timecontainer.text = time.ToString("n2");
        scorecontainer.text = score.ToString();
    }

    void playAudio(int x)
    {
        audiosrc.clip = audioClips[x]; // play corresponding audio clip
        audiosrc.Play(); // Audio source attached to the player
    }
}
