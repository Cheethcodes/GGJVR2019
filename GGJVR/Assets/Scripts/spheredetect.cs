// Created by:      Gabriel Hansley Suarez
// Date Created:    January 26, 2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spheredetect : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "arko")
        {
            SceneManager.LoadScene(1);
        }

        if (other.gameObject.name == "arko (1)")
        {
            SceneManager.LoadScene(1);
        }

        if (other.gameObject.name == "arko (2)")
        {
            SceneManager.LoadScene(1);
        }
    }

}
