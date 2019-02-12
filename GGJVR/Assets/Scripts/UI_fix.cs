// Created by:      Gabriel Hansley Suarez
// Date Created:    January 26, 2019

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_fix : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (EventSystem.current.IsPointerOverGameObject())
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {

        }
    }
}
