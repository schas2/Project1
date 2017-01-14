using UnityEngine;
using System.Collections;

public class ConveyorController : MonoBehaviour
{
	public float speed;
	public StoryTeller script;

	public Camera cameraBadEnd;
	public Camera cameraEnd;

	void Awake() {
		cameraEnd.enabled = false;
	}

	void Update() {
		float zPosition = transform.position.z;

		transform.position = new Vector3(transform.position.x, transform.position.y, zPosition + speed);
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Hammer") {
			if (gameObject.tag == "Kyle" && cameraBadEnd.enabled == true) {
				cameraBadEnd.enabled = false;
				cameraEnd.enabled = true;
				script.endGame();
			}
			Destroy(gameObject);
		}
	}
}
