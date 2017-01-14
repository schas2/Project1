using UnityEngine;
using System.Collections;

public class CodeScript : MonoBehaviour, InputReceiver {
	public GameObject dialogHolder;
	public GameObject player;
	public NavigationManager naviManager;
	private float gameStartTime;

	void Start ()
	{
		gameStartTime = Time.time;

		// Aktualisiere Status (nur, wenn das Level nicht schon abgeschlossen ist)
		if (!(GameMemory.getRoom3State () is LevelCompleted)) {
			GameMemory.setRoom3State (new StartedRoom3 ());
			GameMemory.save ();
		}
	}

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("showInputDialog", this);
			PlayerControllerRoom3.setCanMove (false);

		} else {
			dialogHolder.SendMessage ("setText", "Das ist sicher der Wächter der Tür.");
		}
	} 

	public void receivedInput(string input) {
		PlayerControllerRoom3.setCanMove (true);
		if (input == "172") {
			if (GameMemory.getRoom3State() is StartedRoom3) {
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
				// Schliesse Level 3 ab
				GameMemory.setRoom3State (new FinishedRoom3 ());
				// Ermögliche, dass das Outro spielbar wird
				if (GameMemory.getOutroState () is NotAllowedOutro) {
					GameMemory.setOutroState (new NotStartedOutro ());
					GameMemory.addScoreForLevel (3, kiPoints);
				}
				dialogHolder.SendMessage ("setTextDelayed", "Es blinkt grün und piepst leise - ein gutes Zeichen!");
				GameMemory.save ();
			} else {
				dialogHolder.SendMessage ("setTextDelayed", "Den habe ich mir gemerkt!");
			}
			StartCoroutine(naviManager.goMainScene (5));
		} else {
			dialogHolder.SendMessage ("setTextDelayed", "Verdammt, falsche Eingabe...");
		}
	}
}