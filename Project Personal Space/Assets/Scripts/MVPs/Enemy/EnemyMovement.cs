using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour {
	[SerializeField]
	public Transform Destination;
	NavMeshAgent Driver;
	public float DesAccuracy = 5.0f;
	public bool Chase = true;
	// Use this for initialization
	void Start () 
	{
		Driver = this.GetComponent<NavMeshAgent> ();
		if (Driver == null) {
			Debug.LogError ("No driver in unit" + gameObject.name);
		}


	}
	void FixedUpdate()
	{
		if (Chase == true) 
		{
			SetDestination ();
		}
		if(Vector3.Distance (Destination.position, this.transform.position) > DesAccuracy)
		{
			
			Chase = true;

		}

	}
	private void SetDestination()
	{
		if (Destination != null) 
		{
			Vector3 TargetVector = Destination.transform.position;
			Driver.SetDestination (TargetVector);
			if (Vector3.Distance (Destination.position, this.transform.position) < DesAccuracy) {
				TargetVector = this.transform.position;
				Driver.SetDestination (TargetVector);
				Chase = false;
			} 

		}
	}

}
