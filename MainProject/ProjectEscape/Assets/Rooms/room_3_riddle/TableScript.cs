using UnityEngine;
using System.Collections;

public class TableScript : MonoBehaviour {
	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Nur ein Tisch... Ich muss weitersuchen.");
		} else {
			dialogHolder.SendMessage ("setText", "Ich kann den Tisch nicht untersuchen - bin zu weit weg.");
		}
	} 
}
