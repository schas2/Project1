using UnityEngine;
using System.Collections;

public class RedCarpetScript : MonoBehaviour {
	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "A.1.");
		} else {
			dialogHolder.SendMessage ("setText", "Die roten Teppiche scheinen ein Muster zu bilden.");
		}
	} 
}
