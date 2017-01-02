using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Markermanager : MonoBehaviour {
	public GameObject markerTutorial;
	public GameObject markerOutro;
	public GameObject marker1;
	public GameObject marker2;
	public GameObject marker3;
	public Sprite readyToPlaySprite;
	public Sprite completedLevelSprite;
	public Text uiIndexText;
	private bool executed = false;
	
	void Update () {
		if (!executed) {
			uiIndexText.text = "UI-Index: " + GameMemory.uiIndex;
			executed = true;
			deactivateMarkers ();
			activatePlayableLevels ();
			activateCompletedLevels ();
		}
	}

	private void deactivateMarkers() {
		marker1.SetActive (false);
		marker2.SetActive (false);
		marker3.SetActive (false);
		markerOutro.SetActive (false);
		markerTutorial.SetActive (false);
	}

	private void activatePlayableLevels() {
		if (GameMemory.getRoomState (1) is LevelPlayable) {
			marker1.SetActive (true);
			marker1.GetComponent<Image> ().sprite = readyToPlaySprite;
		}
		if (GameMemory.getRoomState (2) is LevelPlayable) {
			marker2.SetActive (true);
			marker2.GetComponent<Image> ().sprite = readyToPlaySprite;
		}
		if (GameMemory.getRoomState (3) is LevelPlayable) {
			marker3.SetActive (true);
			marker3.GetComponent<Image> ().sprite = readyToPlaySprite;
		}
		if (GameMemory.getRoomState (4) is LevelPlayable) {
			markerOutro.SetActive (true);
			markerOutro.GetComponent<Image> ().sprite = readyToPlaySprite;
		}
		if (GameMemory.getRoomState (5) is LevelPlayable) {
			markerTutorial.SetActive (true);
			markerTutorial.GetComponent<Image> ().sprite = readyToPlaySprite;
		}
	}

	private void activateCompletedLevels() {
		if (GameMemory.getRoomState (1) is LevelCompleted) {
			marker1.SetActive (true);
			marker1.GetComponent<Image> ().sprite = completedLevelSprite;
		}
		if (GameMemory.getRoomState (2) is LevelCompleted) {
			marker2.SetActive (true);
			marker2.GetComponent<Image> ().sprite = completedLevelSprite;
		}
		if (GameMemory.getRoomState (3) is LevelCompleted) {
			marker3.SetActive (true);
			marker3.GetComponent<Image> ().sprite = completedLevelSprite;
		}
		if (GameMemory.getRoomState (4) is LevelCompleted) {
			markerOutro.SetActive (true);
			markerOutro.GetComponent<Image> ().sprite = completedLevelSprite;
		}
		if (GameMemory.getRoomState (5) is LevelCompleted) {
			markerTutorial.SetActive (true);
			markerTutorial.GetComponent<Image> ().sprite = completedLevelSprite;
		}
	}
}
