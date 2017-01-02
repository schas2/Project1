using UnityEngine;
using System.Collections;

[System.Serializable]
public class NotStartedOutro : OutroState, LevelPlayable {

	public override void arrive () {
		Debug.Log ("arrive: NotStartedOutro");
	}

	public override void leave () {
		Debug.Log ("leave: NotStartedOutro");
	}
}
