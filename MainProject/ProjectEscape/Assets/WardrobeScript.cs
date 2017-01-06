using UnityEngine;
using System.Collections;

public class WardrobeScript : MonoBehaviour {

	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "X-Ray-Modus: Tischtücher.");
		} else {
			dialogHolder.SendMessage ("setText", "Das Holz scheint recht massiv zu sein. Der X-Ray funktioniert nicht aus dieser Distanz.");
		}
	} 
}
