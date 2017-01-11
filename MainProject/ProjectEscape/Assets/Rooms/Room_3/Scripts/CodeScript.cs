using UnityEngine;
using System.Collections;

public class CodeScript : MonoBehaviour, InputReceiver {
	public GameObject dialogHolder;
	public GameObject player;
	private float gameStartTime;

	void Start ()
	{
		gameStartTime = Time.time;
	}

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			//dialogHolder.SendMessage ("setText", "Richtig. Den Code reintippen und schon bin ich draussen:");
			object[] param = new object[4];
			param [0] = this;
			param [1] = "Drei Zahlen";
			param [2] = 2;
			param [3] = 2;
			dialogHolder.SendMessage ("showInputDialog", param);

		} else {
			dialogHolder.SendMessage ("setText", "Das ist sicher der Wächter der Tür.");
		}
	} 

	public void receivedInput(string input) {
		Debug.Log (input);
		if (input == "172") {
			Debug.Log ("yeah!");
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
			// Schliesse Level 3 ab
			GameMemory.setRoom3State (new FinishedRoom3 ());
			// Ermögliche, dass das Outro spielbar wird
			if (GameMemory.getOutroState () is NotAllowedOutro) {
				GameMemory.setOutroState (new NotStartedOutro ());
				GameMemory.addScoreForLevel (3, kiPoints);
			}
			GameMemory.save ();
		} else {
			Debug.Log ("Nope");
		}
	}
}