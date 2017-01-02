using UnityEngine;
using System.Collections;

[System.Serializable]
public class NotStartedRoom1 : Room1State, LevelPlayable {

	public override void arrive () {
		Debug.Log ("arrive: NotStartedRoom1");
	}

	public override void leave () {
		Debug.Log ("leave: NotStartedRoom1");
	}
}
