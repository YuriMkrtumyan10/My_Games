using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Red : MonoBehaviour {
	public float dis ;
	public Transform target;
	public Transform [] points;
	private int desPoint = 0;
	private NavMeshAgent agent;
	public GameObject player;
	void Start () {

		agent = GetComponent<NavMeshAgent> ();
		agent.autoBraking = false;

		GotoNextPoint ();
	}
	void GotoNextPoint (){
		if (points.Length == 0)
			return;

		agent.destination = points [desPoint].position;
		desPoint = (desPoint + 1) % points.Length; 
	}


	void Update () {

		dis = Vector3.Distance (gameObject.transform.position,player.transform.position);

		if (Input.GetKey (KeyCode.E)) 
		{	
			if (dis <= 10.0f) 
		{

			agent.SetDestination (player.transform.position);
		}
		if (!agent.pathPending && agent.remainingDistance < 0.5f) {
			GotoNextPoint ();
		}

			GotoNextPoint ();
		}
	}
}
