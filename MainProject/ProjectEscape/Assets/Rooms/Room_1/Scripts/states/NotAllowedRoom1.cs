using UnityEngine;
using System.Collections;

[System.Serializable]
public class NotAllowedRoom1 : Room1State {

	public override void arrive () {
		Debug.Log ("arrive: NotAllowedRoom1");
	}

	public override void leave () {
		Debug.Log ("leave: NotAllowedRoom1");
	}
}
