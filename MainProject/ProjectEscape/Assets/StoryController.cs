using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class StoryController : MonoBehaviour {
	public GameObject player;
	public GameObject dialogHolder;
	public Camera rotateCamera;
	private float seconds = 0;
	// Texte für dialog als array
	List<string> textStory = new List<string>();
	int i = 0;


	void Start () {
		Camera.main.enabled = false;
		rotateCamera.enabled = true;

		textStory.Add("Dies ist der Anfang.");
		textStory.Add("Die Mitte");
		textStory.Add("das Ende...");
	}

	void Update() {

		if (Time.time - seconds > 5) {
			seconds = Time.time;
			Debug.Log (seconds);
			// neuer Dialog
			dialogHolder.SendMessage ("setText", textStory [i]);
			i++;
		}

	}
}
