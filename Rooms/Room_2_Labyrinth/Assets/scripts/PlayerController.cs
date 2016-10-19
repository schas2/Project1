using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private NavMeshAgent navMeshAgent;
	void Awake () {
		navMeshAgent = GetComponent<NavMeshAgent> ();
	}

	void Update () {
		Ray ray = Camera.current.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Input.GetButtonDown ("Fire1")) {
			if (Physics.Raycast (ray, out hit, 100)) {
				navMeshAgent.destination = hit.point;
				navMeshAgent.Resume ();
			}
		}
	}
}
