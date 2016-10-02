using UnityEngine;
using System.Collections;

public class ActionListener : MonoBehaviour {

	public void ichRufeDich() {
		Destroy (this.gameObject);
	}

	public void ichRufeDichMitParam(bool param) {
		Debug.Log ("Ich höre dich mit param: " + param);
	}
}
