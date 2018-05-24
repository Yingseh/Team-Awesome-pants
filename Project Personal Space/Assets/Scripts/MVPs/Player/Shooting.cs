using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	GameObject prefab;
	public GameObject FireArm;
	// Use this for initialization
	void Start () 
	{
	
		prefab = Resources.Load ("bullet") as GameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (Input.GetMouseButtonDown (0)) 
		{
			GameObject bullet = Instantiate (prefab) as GameObject;
			bullet.transform.position = FireArm.transform.position + FireArm.transform.forward;
			Rigidbody FiredBullet = bullet.GetComponent<Rigidbody> ();
			FiredBullet.velocity = FireArm.transform.forward * 40;
		}
	}
}
