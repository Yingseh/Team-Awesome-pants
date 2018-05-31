using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dying : MonoBehaviour {
	//public GameObject Self;
	public bool LifeState;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	 void OnTriggerEnter(Collider other)
	{ 
		if (other.gameObject.CompareTag ("DeathOBall") )
		{
			Destroy (gameObject);
			Destroy (other.gameObject);
			LifeState = false;
			//Waves.text = "Kill Confirmed";
		}
	}
}

