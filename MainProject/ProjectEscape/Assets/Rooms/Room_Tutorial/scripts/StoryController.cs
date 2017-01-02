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
	String[] textStory = {
		"Dies ist der Anfang.",
		"Die Mitte",
		"das Ende..."
	};
	int i = 0;


	void Start () {
		// Aktualisiere Status!
		GameMemory.setTutorialState (new StartedTutorial ());
		GameMemory.save ();

		Camera.main.enabled = false;
		rotateCamera.enabled = true;
	}

	void Update() {

		if (Time.time - seconds > 5) {
			if (i > 3) {
				GameMemory.setTutorialState (new FinishedTutorial ());
				GameMemory.save ();
			}
			seconds = Time.time;
			Debug.Log (seconds);
			// neuer Dialog
			dialogHolder.SendMessage ("setText", textStory [i]);
			i++;
		}

	}
}
