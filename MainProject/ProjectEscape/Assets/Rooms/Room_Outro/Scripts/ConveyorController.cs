using UnityEngine;
using System.Collections;

public class ConveyorController : MonoBehaviour
{
	public float speed;

	void Update() {
		float zPosition = transform.position.z;

		transform.position = new Vector3(transform.position.x, transform.position.y, zPosition + speed);
	}
}
