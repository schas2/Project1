using UnityEngine;
using System.Collections;

[System.Serializable]
public abstract class BaseState {
	public abstract void arrive ();

	public abstract void leave ();
}
