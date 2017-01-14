using UnityEngine;
using System.Collections;

public class PlayerControllerRoom3 : MonoBehaviour {
	NavMeshAgent navMeshAgent;
	private Animator anim;
	private int buffer = 0;
	private static bool canMove = true;

	void Start()
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
		anim = GetComponent<Animator> ();
	}

	void Update()
	{
		Camera cam = Camera.allCameras [0];
		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		Debug.Log ("canmove: " + canMove);
		if (canMove) {
			if (Input.GetButtonDown ("Fire1")) {
				if (Physics.Raycast (ray, out hit, 100)) {
					navMeshAgent.destination = hit.point;
					navMeshAgent.Resume ();
					anim.SetBool ("walking", true);
					buffer = 0;
				}
			}
			//Debug.Log (navMeshAgent.velocity);
			if (navMeshAgent.velocity.x.Equals (0f) && navMeshAgent.velocity.y.Equals (0f) && navMeshAgent.velocity.z.Equals (0f)) {
				buffer++; 
				if (buffer > 3) {
					anim.SetBool ("walking", false);
				}

			}
		}
	}

	public static void setCanMove(bool movingAllowed) {
		Debug.Log ("->: " + movingAllowed);
		canMove = movingAllowed;
	}
}
