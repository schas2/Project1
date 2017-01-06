using UnityEngine;
using System.Collections;

public class DrawerScript : MonoBehaviour {

	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "X-Ray-Modus: Da sind nur alte Socken drin.");
		} else {
			dialogHolder.SendMessage ("setText", "Ich will nicht ausprobieren, ob sie riechen.");
		}
	} 
}
