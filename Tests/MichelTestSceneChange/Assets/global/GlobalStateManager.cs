using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalStateManager :  MonoBehaviour {
	public static Dictionary<int, bool> levels = new Dictionary<int, bool> ();

	// Use this for initialization
	void Start () {
		// This object will live forever! FOREVER!!!
		DontDestroyOnLoad(this);

		// Add some levels
		levels.Add (1, true);
		levels.Add (2, false);
	}

	// Update is called once per frame
	void Update () {
		bool value;
		Debug.Log ("Ha! Ich lebe noch");
		GlobalStateManager.levels.TryGetValue (1, out value);
		Debug.Log ("Level 1 bestanden? " + value);
		GlobalStateManager.levels.TryGetValue (2, out value);
		Debug.Log ("Level 2 bestanden? " + value);
	}
}