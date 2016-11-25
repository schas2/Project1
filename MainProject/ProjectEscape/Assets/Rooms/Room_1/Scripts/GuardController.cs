using UnityEngine;

public class GuardController : MonoBehaviour
{
	public Transform[] patrolPoints;

	private int nextDestinationNumber = 0;
	private NavMeshAgent navMeshAgent;

	void Awake()
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
		navMeshAgent.autoBraking = false;

		GotoNextPoint();
	}

	void Update()
	{
		if (navMeshAgent.remainingDistance < 0.5f) {
			GotoNextPoint();
		}
	}

	private void GotoNextPoint()
	{
		// Avoid error if no patrol points are set
		if (patrolPoints.Length == 0) {
			return;
		}

		// Go to next patrol point
		navMeshAgent.destination = patrolPoints[nextDestinationNumber].position;

		// Get next patrol point to visit
		nextDestinationNumber = (nextDestinationNumber + 1) % patrolPoints.Length;
	}
}
