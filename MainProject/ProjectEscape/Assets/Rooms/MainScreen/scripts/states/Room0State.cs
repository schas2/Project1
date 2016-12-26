using UnityEngine;
using System.Collections;

[System.Serializable]
public class Room0State : BaseState {

	public override void arrive () {
		Debug.Log ("arrive: Room0State");
	}

	public override void leave () {
		Debug.Log ("leave: Room0State");
	}
}
