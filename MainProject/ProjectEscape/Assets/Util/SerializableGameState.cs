using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class SerializableGameState {
	public Dictionary<int, BaseState> roomStates = new Dictionary<int, BaseState> ();

	public void print() {
		for (int i = 0; i < roomStates.Count; i++) {
			Debug.Log (roomStates [i]);
		}
	}
}
