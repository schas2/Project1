using UnityEngine;
using System.Collections;

[System.Serializable]
public class FinishedRoom1 : Room1State, LevelCompleted {

	public override void arrive () {
		Debug.Log ("arrive: FinishedRoom1");
	}

	public override void leave () {
		Debug.Log ("leave: FinishedRoom1");
	}
}
