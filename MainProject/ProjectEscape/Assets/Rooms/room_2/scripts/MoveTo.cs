using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {
	NavMeshAgent navMeshAgent;
	private Animator anim;
	private int buffer = 0;

	void Start()
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
		anim = GetComponent<Animator> ();		

		// Aktualisiere Status (nur, wenn das Level nicht schon abgeschlossen ist)
		if (!(GameMemory.getRoomState (2) is LevelCompleted)) {
			GameMemory.setRoom2State (new StartedRoom2 ());
			GameMemory.save ();
		}
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
				anim.SetBool ("walking", true);
				buffer = 0;
			}
		}
		//Debug.Log (navMeshAgent.velocity);
		if (navMeshAgent.velocity.x.Equals(0f) && navMeshAgent.velocity.y.Equals(0f) && navMeshAgent.velocity.z.Equals(0f)) {
			buffer++; 
			if (buffer > 3) {
				anim.SetBool ("walking", false);
			}
				
		}
	}
}
