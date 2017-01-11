using UnityEngine;
using System.Collections;

[System.Serializable]
public class StartedRoom1 : Room1State, LevelPlayable {
	private int tries = 0;

	public override void arrive () {
		Debug.Log ("arrive: StartedRoom1, tries="+tries);
	}

	public override void leave () {
		Debug.Log ("leave: StartedRoom1");
	}

	public int getTries() {
		return tries;
	}

	public void addTry() {
		tries++;
		Debug.Log ("Tries: " + tries);
	}
}
