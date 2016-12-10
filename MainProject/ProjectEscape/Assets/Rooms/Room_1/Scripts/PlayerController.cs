using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public Text playerNotification;
	public GameObject dialogHolder;

	public Camera mainCamera;
	public Camera room1Camera;
	public Camera room2Camera;
	public Camera room3Camera;

	private bool gameRunning;

	private NavMeshAgent navMeshAgent;
	private Animator animator;
	private int buffer;

	void Awake()
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
		animator = GetComponent<Animator>();

		mainCamera.enabled = true;
		room1Camera.enabled = false;
		room2Camera.enabled = false;
		room3Camera.enabled = false;

		playerNotification.text = "";
		dialogHolder.SetActive(false);
		gameRunning = true;
	}

	void Start()
	{
		dialogHolder.SetActive(true);
		playerNotification.text = "Hinter diesen Türen sind bestimmt Wachen...\n" +
		"Wenn ich auf die Konsole zugreife, kann ich die Sicherheitscameras anzapfen.";
	}

	void Update()
	{
		if (mainCamera.enabled && gameRunning) {
			CheckMouseActions();
		} else {
			if (Input.GetButtonDown("Fire1")) {
				if (room1Camera.enabled) {
					DeactivateCameras();
					room2Camera.enabled = true;
					playerNotification.text = "SecCam Room 102.\nPress ESC to return.";
				} else if (room2Camera.enabled) {
					DeactivateCameras();
					room3Camera.enabled = true;
					playerNotification.text = "SecCam Room 103.\nPress ESC to return.";
				} else if (room3Camera.enabled) {
					DeactivateCameras();
					room1Camera.enabled = true;
					playerNotification.text = "SecCam Room 101.\nPress ESC to return.";
				}
			} else if (Input.GetKeyDown(KeyCode.Escape)) {
				DeactivateCameras();
				mainCamera.enabled = true;
				dialogHolder.SetActive(false);
			}
		}

		if (navMeshAgent.velocity.Equals(new Vector3(0, 0, 0))) {
			buffer++;
			if (buffer > 3) {
				animator.SetBool("walking", false);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("LevelEnd")) {
			dialogHolder.SetActive(true);
			playerNotification.text = "Ja, ich habe es geschafft!";
			gameRunning = false;
		} else if (other.gameObject.CompareTag("Detected")) {
			dialogHolder.SetActive(true);
			playerNotification.text = "Oh nein, voll erwischt!";
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
			dialogHolder.SetActive(false);

			if (Physics.Raycast(ray, out hit, 100)) {
				if (hit.collider.tag == "Door") {
					GameObject go = hit.collider.gameObject;
					DoorController controller = (DoorController)go.GetComponent(typeof(DoorController));
					if (controller != null) {
						controller.OperateDoor();
					}
				} else if (hit.collider.tag == "Console") {
					dialogHolder.SetActive(true);
					DeactivateCameras();
					room1Camera.enabled = true;
					playerNotification.text = "SecCam Room 101.\nPress ESC to return.";
				} else {
					animator.SetBool("walking", true);
					buffer = 0;

					navMeshAgent.destination = hit.point;
					navMeshAgent.Resume();
				}
			}
		}
	}
}
