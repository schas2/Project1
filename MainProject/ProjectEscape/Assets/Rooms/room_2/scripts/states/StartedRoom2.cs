using UnityEngine;
using System.Collections;

public class StartedRoom2 : Room2State {

	public override void arrive () {
		Debug.Log ("arrive: StartedRoom2");
	}

	public override void leave () {
		Debug.Log ("leave: StartedRoom2");
	}
}
