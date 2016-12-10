using UnityEngine;

public class CameraController : MonoBehaviour
{
	public float rotate;

	void Update()
	{
		transform.rotation = Quaternion.Euler(
			transform.eulerAngles.x,
			(Mathf.Sin(Time.realtimeSinceStartup) * rotate) + transform.eulerAngles.y,
			transform.eulerAngles.z
		);
	}
}
