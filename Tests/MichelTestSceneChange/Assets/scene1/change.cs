using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)){
			SceneManager.LoadScene(1);
			GlobalStateManager.levels [2] = true;
		}
		// This accesses a state from the undestroyable GlobalStateManager
		bool value;
		GlobalStateManager.levels.TryGetValue (2, out value);
	}
}