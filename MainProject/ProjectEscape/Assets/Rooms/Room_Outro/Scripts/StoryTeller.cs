using UnityEngine;
using System.Collections;

public class StoryTeller : MonoBehaviour
{
	public Camera cameraGoodEnd;
	public Camera cameraBadEnd;

	void Awake() {
		int score = GameMemory.getScore();
		if (score < 50) {
			cameraGoodEnd.enabled = false;
			cameraBadEnd.enabled = true;
		} else {
			cameraGoodEnd.enabled = true;
			cameraBadEnd.enabled = false;
		}
	}
}
