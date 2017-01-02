using UnityEngine;
using System.Collections;

[System.Serializable]
public class NotAllowedTutorial : TutorialState {

	public override void arrive () {
		Debug.Log ("arrive: NotAllowedTutorial");
	}

	public override void leave () {
		Debug.Log ("leave: NotAllowedTutorial");
	}
}
