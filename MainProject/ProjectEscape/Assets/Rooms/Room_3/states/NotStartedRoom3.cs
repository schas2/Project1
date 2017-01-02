using UnityEngine;
using System.Collections;

[System.Serializable]
public class NotStartedRoom3 : Room3State, LevelPlayable {

	public override void arrive () {
		Debug.Log ("arrive: NotStartedRoom3");
	}

	public override void leave () {
		Debug.Log ("leave: NotStartedRoom3");
	}
}
