using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	public GameObject player;

	void Update () {
		transform.RotateAround (player.transform.position, Vector3.up, 10 * Time.deltaTime);
	}
}
