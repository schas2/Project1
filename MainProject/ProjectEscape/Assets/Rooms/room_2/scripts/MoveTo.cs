using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {
	NavMeshAgent navMeshAgent;
	void Start()
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
	}

	void Update()
	{
		Camera cam = Camera.allCameras [0];
		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Input.GetButtonDown("Fire1"))
		{
			if (Physics.Raycast(ray, out hit, 100))
			{
				navMeshAgent.destination = hit.point;
				navMeshAgent.Resume();
			}
		}
	}
}
