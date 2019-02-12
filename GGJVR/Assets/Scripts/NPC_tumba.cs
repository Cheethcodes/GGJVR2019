// Created by:      Gabriel Hansley Suarez
// Date Created:    January 26, 2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_tumba : MonoBehaviour {

    GameObject menu;

    private void Start()
    {
        menu = GameObject.Find("btn_menu");
    }

    private void OnMouseDown()
    {
        if (!menu.activeSelf)
            menu.SetActive(true);
        else
            menu.SetActive(false);
    }
}
