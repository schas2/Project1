using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour {
	public GameObject dialogHolder;
	private float gameStartTime;


	void Start ()
	{
		gameStartTime = Time.time;
	}

	// Use this for initialization
	void OnMouseDown () {
		Debug.Log (gameStartTime);
		Debug.Log (Time.time);
		Debug.Log (gameStartTime - Time.time);
		dialogHolder.SendMessage ("setText", "hadfkasdfjadsfsdfkj");
	}
}
