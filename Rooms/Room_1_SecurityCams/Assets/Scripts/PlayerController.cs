using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;

    public Camera mainCamera;
    public Camera room1Camera;
    public Camera room2Camera;
    public Camera room3Camera;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        mainCamera.enabled = true;
        room1Camera.enabled = false;
        room2Camera.enabled = false;
        room3Camera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (mainCamera.enabled)
            {
                DeactivateCameras();
                room1Camera.enabled = true;
            }
            else if (room1Camera.enabled)
            {
                DeactivateCameras();
                room2Camera.enabled = true;
            }
            else if (room2Camera.enabled)
            {
                DeactivateCameras();
                room3Camera.enabled = true;
            }
            else if (room3Camera.enabled)
            {
                DeactivateCameras();
                mainCamera.enabled = true;
            }
        }

        if (mainCamera.enabled)
        {
            CheckMouseActions();
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

        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.tag != "Door")
                {
                    navMeshAgent.destination = hit.point;
                    navMeshAgent.Resume();
                }
                else if (hit.collider.tag == "Door")
                {
                    GameObject go = hit.collider.gameObject;
                    DoorController controller = (DoorController)go.GetComponent(typeof(DoorController));
                    if (controller != null)
                    {
                        controller.OperateDoor();
                    }
                }
            }
        }
    }
}
