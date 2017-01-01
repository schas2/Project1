using UnityEngine;
using System.Collections;

[System.Serializable]
public class FinishedOutro : OutroState
{
	public override void arrive() {
		Debug.Log("arrive: FinishedOutro");
	}

	public override void leave() {
		Debug.Log("leave: FinishedOutro");
	}
}
