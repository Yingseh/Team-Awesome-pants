using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheShield : MonoBehaviour {
	GameObject Prefab;
	public bool ShieldUp = false;
	public float CoolDown = 10;
	private float Cooled = 0;
	public float ShieldLowering = 5;
	private float ShielDown = 0;
	public Transform FaceTarget;
	GameObject shield;
	// Use this for initialization
	void Start () 
	{
		Prefab =  Resources.Load ("Shield") as GameObject;	
		shield = Prefab;
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*if (Input.GetMouseButtonDown (1)) {
			GameObject Shield = Instantiate (Prefab) as GameObject;
			Shield.transform.position = transform.position + transform.forward *3;
			shield.transform.localRotation = transform.localRotation;
			//shield.transform.rotation = transform.rotation;
		}*/
		if (ShieldUp == true) 
		{
			Debug.Log ("counting down");
			
		}
		if (Time.time > Cooled) 
		{
			Debug.Log ("ready");
			if (Input.GetMouseButtonDown (1) && ShieldUp == false) 
			{
				Debug.Log ("deployed");
				GameObject Shield = Instantiate (Prefab) as GameObject;
				Shield.transform.position = FaceTarget.transform.position;
				shield.transform.rotation = transform.localRotation;
				//shield.transform.LookAt(FaceTarget);
				ShieldUp = true;
				ShielDown = Time.time + ShieldLowering;

				Cooled = Time.time + CoolDown;
			}
		}

		if (Time.time > ShielDown) 
		{
				
			ShieldUp = false;
		}

	}
}
