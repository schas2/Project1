using UnityEngine;
using System.Collections;

public class PlantRightScript : MonoBehaviour {
	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Wenn ich sonst nichts finde, liege ich darunter und schaue, ob etwas auf einem Blatt steht.");
		} else {
			dialogHolder.SendMessage ("setText", "Wenn meine Analyse richtig ist, handelt es sich dabei um eine Zimmerpflanze.");
		}
	} 
}