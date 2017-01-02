using UnityEngine;
using System.Collections;

[System.Serializable]
public class FinishedTutorial : TutorialState, LevelCompleted
{
	public override void arrive() {
		Debug.Log("arrive: FinishedTutorial");
	}

	public override void leave() {
		Debug.Log("leave: FinishedTutorial");
	}
}
