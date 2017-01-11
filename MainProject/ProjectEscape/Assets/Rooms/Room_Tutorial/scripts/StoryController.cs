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
	bool skipText = false;


	void Start () {
		// Aktualisiere Status (nur, wenn das Level nicht schon abgeschlossen ist)
		if (!(GameMemory.getRoomState (5) is LevelCompleted)) {
			GameMemory.setTutorialState (new StartedTutorial ());
			GameMemory.save ();
		}

		Camera.main.enabled = false;
		rotateCamera.enabled = true;
	}

	void Update() {

		if (Time.time - seconds > 5 && !skipText) {
			if (i >= 3) {
				// Schliesse Tutorial ab
				GameMemory.setTutorialState (new FinishedTutorial ());
				// Ermögliche, dass Level 1 spielbar wird
				if (GameMemory.getRoom1State () is NotAllowedRoom1) {
					GameMemory.setRoom1State (new NotStartedRoom1 ());
					// Setze die Punktzahl
					GameMemory.addScoreForLevel (0, 100);
				}
				GameMemory.save ();

				skipText = true;
				return;
			}
			seconds = Time.time;
			Debug.Log (seconds);
			// neuer Dialog
			dialogHolder.SendMessage ("setText", textStory [i]);
			i++;
		}

	}
}
