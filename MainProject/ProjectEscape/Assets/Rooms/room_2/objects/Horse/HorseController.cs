using UnityEngine;
using System.Collections;
// https://docs.unity3d.com/Manual/nav-AgentPatrol.html
public class HorseController : MonoBehaviour {
	public Transform[] points;
	private int destPoint = 0;
	private NavMeshAgent agent;
	private int buffer = 0;
	public GameObject dialogHolder;

	void OnMouseDown(){
		dialogHolder.SendMessage ("setText", "Ein Pferd? Sollte ich ihm folgen oder nicht?");
	} 


	void Start () {
		agent = GetComponent<NavMeshAgent>();

		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		agent.autoBraking = false;

		GotoNextPoint();
		agent.speed = 3;
	}


	void GotoNextPoint() {
		// Returns if no points have been set up
		if (points.Length == 0)
			return;

		// Set the agent to go to the currently selected destination.
		agent.destination = points[destPoint].position;

		// Choose the next point in the array as the destination,
		// cycling to the start if necessary.
		destPoint = (destPoint + 1) % points.Length;
	}


	void Update () {
		// Choose the next destination point when the agent gets
		// close to the current one.
		if (agent.remainingDistance < 2.5f) {
			buffer ++;
			if (buffer == 3) {
				GotoNextPoint ();
				buffer = 0;
			}
		}
	}
}
