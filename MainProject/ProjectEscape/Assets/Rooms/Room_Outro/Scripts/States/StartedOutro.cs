using UnityEngine;
using System.Collections;

[System.Serializable]
public class StartedOutro : OutroState, LevelPlayable
{
	public override void arrive() {
		Debug.Log("arrive: StartedOutro");
	}

	public override void leave() {
		Debug.Log("leave: StartedOutro");
	}
}
