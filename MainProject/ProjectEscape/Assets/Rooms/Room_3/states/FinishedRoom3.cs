using UnityEngine;
using System.Collections;

[System.Serializable]
public class FinishedRoom3 : Room3State {

	public override void arrive () {
		Debug.Log ("arrive: FinishedRoom3");
	}

	public override void leave () {
		Debug.Log ("leave: FinishedRoom3");
	}
}
