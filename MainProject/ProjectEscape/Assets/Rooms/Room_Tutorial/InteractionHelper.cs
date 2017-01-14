using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InteractionHelper : MonoBehaviour {
	public GameObject container;
	public InputField inputField;
	public Text textField;
	public GameObject inputPanel;
	public GameObject textPanel;
	InputReceiver currentReceiver;

	private bool alreadyActive = false;

	public IEnumerator setText(string text) {
		if (!alreadyActive) {
			prepareTextPanel ();
			textField.text = text;
			yield return new WaitForSeconds (3);
			exitTextPanel ();
		} else {
			Debug.Log ("Man kann nicht zwei Texte gleichzeitig anzeigen...");
		}
	}

	public IEnumerator setTextDelayed(string text) {
		yield return new WaitForSeconds (0.1f);
		StartCoroutine(setText (text));
	}

	public void showInputDialog(object[] param) {
		if (!alreadyActive) {
			prepareInputPanel ();

			currentReceiver = (InputReceiver)param [0];
			string placeholder = (string)param [1];
			int scaleX = (int)param [2];
			int scaleY = (int)param [3];
			// TODO set placeholder+scales
		}
	}

	// Wird aufgerufen, wenn der User den Button klickt.
	public void closeInputDialog() {
		currentReceiver.receivedInput (inputField.text);
		exitInputPanel ();
		currentReceiver = null;
	}

	void Awake () {
		container.gameObject.SetActive (false);
	}

	private void prepareTextPanel() {
		alreadyActive = true;
		Debug.Log (alreadyActive);
		container.SetActive (true);
		textPanel.SetActive (true);
		inputPanel.SetActive (false);
	}

	private void exitTextPanel() {
		alreadyActive = false;
		Debug.Log (alreadyActive);
		container.SetActive (false);
		textPanel.SetActive (false);
		inputPanel.SetActive (false);
	}

	private void prepareInputPanel() {
		alreadyActive = true;
		Debug.Log (alreadyActive);
		container.SetActive (true);
		textPanel.SetActive (false);
		inputPanel.SetActive (true);
	}

	private void exitInputPanel() {
		alreadyActive = false;
		Debug.Log (alreadyActive);
		container.SetActive (false);
		textPanel.SetActive (false);
		inputPanel.SetActive (false);
	}

}