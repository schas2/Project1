using UnityEngine;
using System.Collections;

public class HammerController : MonoBehaviour
{
	public float speed;

	private int direction = -1;

	void Update() {
		float yPosition = transform.position.y;

		if (yPosition <= 5 || yPosition >= 14) { 
			direction *= -1;
		}

		transform.position = new Vector3(transform.position.x, yPosition + direction * speed, transform.position.z);
	}
}
