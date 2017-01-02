using UnityEngine;
using System.Collections;

[System.Serializable]
public class NotAllowedRoom2 : Room2State {

	public override void arrive () {
		Debug.Log ("arrive: NotAllowedRoom2");
	}

	public override void leave () {
		Debug.Log ("leave: NotAllowedRoom2");
	}
}
