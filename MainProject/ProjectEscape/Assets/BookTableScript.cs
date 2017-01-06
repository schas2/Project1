using UnityEngine;
using System.Collections;

public class BookTableScript : MonoBehaviour {
	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Ein Buch über Games und Farben. Eine schlechtere K.I. könnte sich hier weiterbilden. Ich habe das alles schon gelernt.");
		} else {
			dialogHolder.SendMessage ("setText", "Auf dem Tisch liegt ein Buch.");
		}
	} 
}
