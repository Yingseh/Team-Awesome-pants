using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class EnemyMovement : MonoBehaviour {
	public int PlayerHealth = 10;
	public Text HealthUI;
	public GameObject Player;
	[SerializeField]
	GameObject Destination;
	NavMeshAgent Driver;
	public float DesAccuracy = 2.0f;
	private bool Chase = true;
	// Use this for initialization
	void Start () 
	{
		
		Destination = GameObject.FindGameObjectWithTag ("Player");
		Driver = this.GetComponent<NavMeshAgent> ();
		if (Driver == null) 
		{
			Debug.LogError ("No driver in unit" + gameObject.name);
		}
	}

	void FixedUpdate()
	{
		if (Chase == true) 
		{
			SetDestination ();
		}
		if(Vector3.Distance (Destination.transform.position, this.transform.position) > DesAccuracy)
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
			if (Vector3.Distance (Destination.transform.position, this.transform.position) < DesAccuracy) {
				TargetVector = this.transform.position;
				Driver.SetDestination (TargetVector);
				Chase = false;

			} 
		
		}
	}


}
