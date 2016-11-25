using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InteractionHelper : MonoBehaviour {
	public GameObject container;
	public Text textField;

	private bool alreadyActive = false;

	public IEnumerator setText(string text) {
		if (!alreadyActive) {
			alreadyActive = true;
			container.SetActive (true);
			textField.text = text;
			yield return new WaitForSeconds (3);
			container.SetActive (false);
			alreadyActive = false;
		}
	}

	void Awake () {
		container.gameObject.SetActive (false);
	}

}