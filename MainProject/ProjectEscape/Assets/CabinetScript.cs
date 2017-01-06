using UnityEngine;
using System.Collections;

public class CabinetScript : MonoBehaviour {

	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Ich habe ein grösseres Wissen als tausende solche Bücher.");
		} else {
			dialogHolder.SendMessage ("setText", "Ein Gestell voller mittelalter Schunken.");
		}
	}
}
