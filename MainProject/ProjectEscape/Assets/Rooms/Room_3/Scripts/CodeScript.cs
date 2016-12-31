using UnityEngine;
using System.Collections;

public class CodeScript : MonoBehaviour, InputReceiver {
	public GameObject dialogHolder;
	public GameObject player;

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
		} else {
			Debug.Log ("Nope");
		}
	}
}