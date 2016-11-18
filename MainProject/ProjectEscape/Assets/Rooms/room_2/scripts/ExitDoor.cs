using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour {
	public GameObject dialogHolder;

	// Use this for initialization
	void OnMouseDown () {
		Debug.Log ("1");
		dialogHolder.SendMessage ("setText", "hadfkasdfjadsfsdfkj");
	}
}
