using UnityEngine;
using System.Collections;

public class PCScript : MonoBehaviour {

	public GameObject dialogHolder;
	public GameObject player;

	public IEnumerator OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Windows. Keine Internetverbindung.");
			yield return new WaitForSeconds (3);
			Debug.Log ("hö");
			dialogHolder.SendMessage ("setText", "Dann nützt mir diese Kiste nichts.");
		} else {
			dialogHolder.SendMessage ("setText", "Die Schriftgrösse ist zu klein.");
		}
	}

	public IEnumerator wait() {
		yield return new WaitForSeconds(6);
	}
}