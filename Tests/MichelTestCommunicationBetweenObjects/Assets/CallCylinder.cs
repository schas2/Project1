using UnityEngine;
using System.Collections;

public class CallCylinder : MonoBehaviour {
	public GameObject otherObject;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)){
			Debug.Log ("click");
			otherObject.SendMessage ("ichRufeDich");
			otherObject.SendMessage ("ichRufeDichMitParam", true);
		}
	}
}
