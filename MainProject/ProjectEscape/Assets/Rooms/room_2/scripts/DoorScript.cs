using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {
	private float gameStartTime;
	public NavigationManager naviManager;
	public GameObject dialogHolder;

	void Start ()
	{
		gameStartTime = Time.time;
	}

	// Use this for initialization
	void OnMouseDown () {
		if (GameMemory.getRoom2State () is StartedRoom2) {
			float playedMinutes = (Time.time - gameStartTime) / 60;
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
			dialogHolder.SendMessage ("setText", "Wow... Wo komme ich denn hier hin?");
			StartCoroutine (naviManager.goMainScene (5));
			GameMemory.save ();
		} else {
			dialogHolder.SendMessage ("setText", "Wieso tue ich mir das immer wieder an?");
			StartCoroutine(naviManager.goMainScene (5));
		}
	} 
}
