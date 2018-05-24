using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dying : MonoBehaviour {
	//public GameObject Self;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
	

	}
	void OnTriggerEnter(Collider other)
	{ 
		if (other.gameObject.CompareTag ("DeathOBall") )
		{
			Destroy (gameObject);
			Destroy (other.gameObject);
		}
	}
}

