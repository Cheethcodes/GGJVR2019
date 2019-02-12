// Created by Gabriel Hansley Suarez

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRTK;
using VRTK.Examples;
using VRTK.Controllables;

public class buttonscipt : MonoBehaviour
{
    public int sceneNumber;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void loadScene2()
    {
        SceneManager.LoadScene(2);
    }

    public void loadScene3()
    {
        SceneManager.LoadScene(3);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "[VRTK][AUTOGEN][LeftControllerScriptAlias][BasePointerRenderer_Origin_Smoothed]" || other.gameObject.name == "[VRTK][AUTOGEN][RightControllerScriptAlias][BasePointerRenderer_Origin_Smoothed]")
        {
            if (sceneNumber == 1)
            {
                SceneManager.LoadScene(1);
            }
            if (sceneNumber == 2)
            {
                SceneManager.LoadScene(2);
            }
            if (sceneNumber == 3)
            {
                SceneManager.LoadScene(3);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "[VRTK][AUTOGEN][LeftControllerScriptAlias][BasePointerRenderer_Origin_Smoothed]" || other.gameObject.name == "[VRTK][AUTOGEN][RightControllerScriptAlias][BasePointerRenderer_Origin_Smoothed]")
        {
            if (sceneNumber == 1)
            {
                SceneManager.LoadScene(1);
            }
            if (sceneNumber == 2)
            {
                SceneManager.LoadScene(2);
            }
            if (sceneNumber == 3)
            {
                SceneManager.LoadScene(3);
            }
        }
    }

}
