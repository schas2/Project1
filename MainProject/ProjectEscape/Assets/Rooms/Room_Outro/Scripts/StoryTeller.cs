using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StoryTeller : MonoBehaviour
{
	public Camera cameraGoodEnd;
	public Camera cameraBadEnd;

	public Text playerNotification;
	public GameObject ui;

	public NavigationManager naviManager;

	public float countdown;

	void Awake() {
		int score = GameMemory.getScore();
		if (score < 70) {
			cameraGoodEnd.enabled = false;
			cameraBadEnd.enabled = true;
			ui.SetActive(false);
		} else {
			cameraGoodEnd.enabled = true;
			cameraBadEnd.enabled = false;
			ui.SetActive(true);
			playerNotification.text = "Wissenschaftler Herbert: Zwei Ferienwochen extra!!!\nDanke, du bist super!";
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
		GameMemory.save();

		StartCoroutine(naviManager.goMainScene(5));
	}
}
