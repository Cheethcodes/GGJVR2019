// Created by:      Gabriel Hansley Suarez
// Date Created:    January 26, 2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager_toss : MonoBehaviour {

    private AudioSource audiosrc;
    public AudioClip[] audioClips;

    private float time = 30f;
    public Text timecontainer;

    public GameObject countdownEndContainer;
    public Text countdownEnd;
    private float countdownTime;

    // Use this for initialization
    void Start () {
        countdownTime = 5f;
        audiosrc = GetComponent<AudioSource>();
        playAudio(0);
        timecontainer.text = time.ToString();
    }

    private void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime * 1;
            time = Mathf.Clamp(time, 0, 30f);
            timecontainer.text = time.ToString("n2");
        }
        else
        {
            countdownEndContainer.SetActive(true);
            countdownTime -= Time.deltaTime * 1;
            countdownTime = Mathf.Clamp(countdownTime, 0, 5f);
            countdownEnd.text = countdownTime.ToString("n2");
            
            if (countdownTime <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    void playAudio(int x)
    {
        audiosrc.clip = audioClips[x]; // play corresponding audio clip
        audiosrc.Play(); // Audio source attached to the player
    }
}
