using UnityEngine;

public class DoorController : MonoBehaviour
{
	private bool isClosed;
	private bool isMoving;

	private int finalPosition;

	void Awake()
	{
		isClosed = true;
		isMoving = false;

		finalPosition = 0;
	}

	void Update()
	{
		if (isMoving && finalPosition < 120) {
			transform.Translate(Vector3.right * Time.deltaTime);
			finalPosition++;
		}
	}

	public void OperateDoor()
	{
		if (isClosed && !isMoving) {
			isMoving = true;
			isClosed = false;
		}
	}
}
