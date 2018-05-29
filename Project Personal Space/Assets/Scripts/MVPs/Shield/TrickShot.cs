using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrickShot : MonoBehaviour {

	GameObject prefab;
	// Use this for initialization
	void Start () 
	{

		prefab = Resources.Load ("bullet") as GameObject;
	}

	// Update is called once per frame
	void OnTriggerEnter(Collider other) 
	{
		
		if (other.CompareTag ("DeathOBall")) 
		{
				GameObject bullet = Instantiate (prefab) as GameObject;
				bullet.transform.position = transform.position * 2;
				Rigidbody FiredBullet = bullet.GetComponent<Rigidbody> ();
				FiredBullet.velocity = transform.forward * 40;
				
			}

	}
}
