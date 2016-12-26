using UnityEngine;
using System.Collections;

[System.Serializable]
public class StartedRoom1 : Room1State {

	public override void arrive () {
		Debug.Log ("arrive: StartedRoom1");
	}

	public override void leave () {
		Debug.Log ("leave: StartedRoom1");
	}
}
