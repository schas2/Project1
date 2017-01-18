using UnityEngine;
using System.Collections;

public class StoryTeller : MonoBehaviour
{
	public Camera cameraGoodEnd;
	public Camera cameraBadEnd;

	public NavigationManager naviManager;

	public float countdown;

	void Awake() {
		int score = GameMemory.getScore();
		if (score < 70) {
			cameraGoodEnd.enabled = false;
			cameraBadEnd.enabled = true;
		} else {
			cameraGoodEnd.enabled = true;
			cameraBadEnd.enabled = false;
		}

		if (!(GameMemory.getOutroState() is LevelCompleted)) {
			GameMemory.setOutroState(new StartedOutro());
			GameMemory.save();
		}
	}

	void Update() {
		countdown -= Time.deltaTime;
		if (countdown < 0) {
			endGame();
		}
	}

	public void endGame() {
		GameMemory.setOutroState(new FinishedOutro());
		StartCoroutine(naviManager.goMainScene(5));
	}
}
