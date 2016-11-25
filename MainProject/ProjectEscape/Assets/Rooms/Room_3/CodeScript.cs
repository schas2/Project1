using UnityEngine;
using System.Collections;

public class CodeScript : MonoBehaviour {
	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Richtig. Den Code reintippen und schon bin ich draussen:");
		} else {
			dialogHolder.SendMessage ("setText", "Das ist sicher der Wächter der Tür.");
		}
	} 
}