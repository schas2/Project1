using UnityEngine;
using System.Collections;

[System.Serializable]
public class NotAllowedRoom3 : Room3State {

	public override void arrive () {
		Debug.Log ("arrive: NotAllowedRoom3");
	}

	public override void leave () {
		Debug.Log ("leave: NotAllowedRoom3");
	}
}
