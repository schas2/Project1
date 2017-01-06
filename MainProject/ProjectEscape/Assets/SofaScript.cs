using UnityEngine;
using System.Collections;

public class SofaScript : MonoBehaviour {

	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Sieht nicht so bequem aus.");
		} else {
			dialogHolder.SendMessage ("setText", "Keine Zeit, um auszuruhen.");
		}
	} 
}
