using UnityEngine;
using System.Collections;

[System.Serializable]
public class NotAllowedOutro : OutroState {

	public override void arrive () {
		Debug.Log ("arrive: NotAllowedOutro");
	}

	public override void leave () {
		Debug.Log ("leave: NotAllowedOutro");
	}
}
