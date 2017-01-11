using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {
	private float gameStartTime;

	void Start ()
	{
		gameStartTime = Time.time;
	}

	// Use this for initialization
	void OnMouseDown () {
		float playedMinutes = (Time.time - gameStartTime)/60;
		int kiPoints;
		if (playedMinutes < 5.0f) {
			kiPoints = 100;
		} else if (playedMinutes < 7.0f) {
			kiPoints = 90;
		} else if (playedMinutes < 9.0f) {
			kiPoints = 80;
		} else if (playedMinutes < 10.0f) {
			kiPoints = 70;
		} else if (playedMinutes < 11.0f) {
			kiPoints = 60;
		} else if (playedMinutes < 12.0f) {
			kiPoints = 50;
		} else if (playedMinutes < 13.0f) {
			kiPoints = 40;
		} else {
			kiPoints = 30;
		}

		// Schliesse Level 2 ab
		GameMemory.setRoom2State (new FinishedRoom2 ());
		// Ermögliche, dass Level 3 spielbar wird
		if (GameMemory.getRoom3State () is NotAllowedRoom3) {
			GameMemory.setRoom3State (new NotStartedRoom3 ());
			GameMemory.addScoreForLevel (2, kiPoints);
		}

		GameMemory.save ();
	} 
}
