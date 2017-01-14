using UnityEngine;
using System.Collections;

public class ExitDoorScript : MonoBehaviour {

	public GameObject dialogHolder;
	public GameObject player;

	void OnMouseDown(){
		float distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 2.5) {
			dialogHolder.SendMessage ("setText", "Die Tür ist geschlossen. Ich muss den Zugangscode in das Kästchen eintippen.");
		} else {
			dialogHolder.SendMessage ("setText", "Durch diese Tür muss ich den Raum verlassen können.");
		}
	}
}