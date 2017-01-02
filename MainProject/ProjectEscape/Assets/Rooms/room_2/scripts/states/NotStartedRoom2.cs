using UnityEngine;
using System.Collections;

[System.Serializable]
public class NotStartedRoom2 : Room2State, LevelPlayable {

	public override void arrive () {
		Debug.Log ("arrive: NotStartedRoom2");
	}

	public override void leave () {
		Debug.Log ("leave: NotStartedRoom2");
	}
}
