// Created by:      Gabriel Hansley Suarez
// Date Created:    January 26, 2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class btnFunctions : MonoBehaviour {
    
    public void closeMenu()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            GameObject.Find("btn_menu").SetActive(false);
        }
    }

    public void restartMenu()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void exitMenu()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            SceneManager.LoadScene(1);
        }
    }
}
