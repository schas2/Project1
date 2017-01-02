﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class StartedRoom3 : Room3State, LevelPlayable {

	public override void arrive () {
		Debug.Log ("arrive: StartedRoom3");
	}

	public override void leave () {
		Debug.Log ("leave: StartedRoom3");
	}
}
