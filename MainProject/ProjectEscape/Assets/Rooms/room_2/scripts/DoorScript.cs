using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	void OnMouseDown(){
		// Schliesse Level 2 ab
		GameMemory.setRoom2State (new FinishedRoom2 ());
		// Ermögliche, dass Level 3 spielbar wird
		GameMemory.setRoom3State (new NotStartedRoom3 ());
		GameMemory.save ();
	} 
}
