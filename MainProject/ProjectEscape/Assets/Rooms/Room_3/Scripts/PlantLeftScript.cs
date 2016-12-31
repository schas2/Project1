using UnityEngine;
using System.Collections;

public class PlantLeftScript : MonoBehaviour {
	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Menschen \"rauchen\" solches Zeug, teils aus medizinischen Gründen. Vielleicht würde das diesem alten Cyborg auchs gut tun.");
		} else {
			dialogHolder.SendMessage ("setText", "Sieht aus wie eine Pflanze.");
		}
	} 
}