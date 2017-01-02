using UnityEngine;
using System.Collections;

[System.Serializable]
public class NotStartedTutorial : TutorialState, LevelPlayable {

	public override void arrive () {
		Debug.Log ("arrive: NotStartedTutorial");
	}

	public override void leave () {
		Debug.Log ("leave: NotStartedTutorial");
	}
}
