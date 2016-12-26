using UnityEngine;
using System.Collections;

[System.Serializable]
public class FinishedRoom2 : Room2State {

	public override void arrive () {
		Debug.Log ("arrive: FinishedRoom2");
	}

	public override void leave () {
		Debug.Log ("leave: FinishedRoom2");
	}
}
