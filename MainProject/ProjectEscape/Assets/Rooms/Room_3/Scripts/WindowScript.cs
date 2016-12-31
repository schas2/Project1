using UnityEngine;
using System.Collections;

public class WindowScript : MonoBehaviour {
	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Hier sieht man zwar nichts.");
		}
		else {
			dialogHolder.SendMessage ("setText", "Ein Fenster hinter einem PC-Fenster. Ein Philosoph würde sich fragen, warum die meisten Menschen lieber in das vordere schauen.");
		}
	} 
}