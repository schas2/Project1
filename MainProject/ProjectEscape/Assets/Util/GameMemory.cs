using UnityEngine;
using System.Collections;

public class GameMemory : MonoBehaviour {
	public static Room2State room2State = new StartedRoom2();

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);
	}
}
