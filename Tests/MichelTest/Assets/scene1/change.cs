﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.A)){
			SceneManager.LoadScene(1);
		}
	}
}