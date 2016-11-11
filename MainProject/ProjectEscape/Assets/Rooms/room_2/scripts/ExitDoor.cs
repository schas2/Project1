using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown () {
		SceneManager.LoadScene (1);
	}
}
