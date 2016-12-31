using UnityEngine;
using System.Collections;

public class BoardScript : MonoBehaviour {
	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 3.5) {
			dialogHolder.SendMessage ("setText", "Was soll denn der Blödsinn?");
		} else {
			dialogHolder.SendMessage ("setText", "Von hier aus kann ich nur ein Diagramm erkennen, nichts Genaueres.");
		}
	} 
}