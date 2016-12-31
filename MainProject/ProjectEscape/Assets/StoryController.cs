using UnityEngine;
using System.Collections;

public class StoryController : MonoBehaviour {
	public GameObject player;
	public Camera rotateCamera;
	private float seconds = 0;
	// Texte für dialog als array

	void Start () {
		Camera.main.enabled = false;
		rotateCamera.enabled = true;
	}

	void Update() {
		if (Time.time - seconds > 5) {
			seconds = Time.time;
			Debug.Log (seconds);
			// neuer Dialog
		}
	}
}
