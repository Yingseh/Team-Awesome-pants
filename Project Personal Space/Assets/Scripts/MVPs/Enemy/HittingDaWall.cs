using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingDaWall : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollision(Collider col)
	{ 
		if (col.gameObject.CompareTag ("DeathOBall")) {
			Destroy (col.gameObject);
		}
	}

}
