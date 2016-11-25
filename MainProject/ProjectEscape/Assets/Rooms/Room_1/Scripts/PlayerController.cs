using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public Text playerNotification;

	public Camera mainCamera;
	public Camera room1Camera;
	public Camera room2Camera;
	public Camera room3Camera;

	private bool gameRunning;

	private NavMeshAgent navMeshAgent;

	void Awake()
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
		mainCamera.enabled = true;
		room1Camera.enabled = false;
		room2Camera.enabled = false;
		room3Camera.enabled = false;

		playerNotification.text = "";
		gameRunning = true;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.C)) {
			if (mainCamera.enabled) {
				DeactivateCameras();
				room1Camera.enabled = true;
			} else if (room1Camera.enabled) {
				DeactivateCameras();
				room2Camera.enabled = true;
			} else if (room2Camera.enabled) {
				DeactivateCameras();
				room3Camera.enabled = true;
			} else if (room3Camera.enabled) {
				DeactivateCameras();
				mainCamera.enabled = true;
			}
		}

		if (mainCamera.enabled && gameRunning) {
			CheckMouseActions();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("LevelEnd")) {
			playerNotification.text = "You Won!";
			gameRunning = false;
		} else if (other.gameObject.CompareTag("Detected")) {
			playerNotification.text = "You Lost!";
			gameRunning = false;
		}
	}

	private void DeactivateCameras()
	{
		mainCamera.enabled = false;
		room1Camera.enabled = false;
		room2Camera.enabled = false;
		room3Camera.enabled = false;
	}

	private void CheckMouseActions()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		if (Input.GetButtonDown("Fire1")) {
			if (Physics.Raycast(ray, out hit, 100)) {
				if (hit.collider.tag != "Door") {
					navMeshAgent.destination = hit.point;
					navMeshAgent.Resume();
				} else if (hit.collider.tag == "Door") {
					GameObject go = hit.collider.gameObject;
					DoorController controller = (DoorController)go.GetComponent(typeof(DoorController));
					if (controller != null) {
						controller.OperateDoor();
					}
				}
			}
		}
	}
}
