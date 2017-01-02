using UnityEngine;
using System.Collections;

[System.Serializable]
public class StartedTutorial : TutorialState, LevelPlayable
{
	public override void arrive() {
		Debug.Log("arrive: StartedTutorial");
	}

	public override void leave() {
		Debug.Log("leave: StartedTutorial");
	}
}
