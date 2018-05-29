using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldsDown : MonoBehaviour 
{

	public float ShieldLowering = 5;
	private float ShielDown = 0;
	void Start ()
	{
		ShielDown = Time.time + ShieldLowering;
	}
	void Update ()
	{
		if (Time.time > ShielDown) 
		{
			Destroy (gameObject);
			//ShielDown = Time.time + ShieldLowering;
		}
	}
}
