using UnityEngine;
using System.Collections;

public class BigPlantScript : MonoBehaviour {

	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Nicht essbar, nicht mit Codes beschriftet, nicht nützlich.");
		} else {
			dialogHolder.SendMessage ("setText", "Eine gewöhnliche Zimmerpflanze. Vielleicht etwas grösser als die meisten.");
		}
	}
}
