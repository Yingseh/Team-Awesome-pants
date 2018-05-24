using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheShield : MonoBehaviour {
	GameObject Prefab;
	public bool ShieldUp = false;
	public int CoolDown = 10;
	public int ShieldLowering = 5;
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
		if (ShieldUp == true) 
		{Debug.Log ("counting down");
			ShieldLowering = ShieldLowering--;
		}
		if (Input.GetMouseButtonDown (1) && ShieldUp == false)
		{
			GameObject Shield = Instantiate (Prefab) as GameObject;
			Shield.transform.position = transform.position + transform.forward * 3f;
			ShieldUp = true;
			ShieldLowering = 5;
			CoolDown = 10;
		}
		//ShieldLowering = ShieldLowering--;
		if (ShieldLowering == 0) 
		{
			
			DestroyObject (shield);	
			CoolDown = CoolDown--;
		}
		if (CoolDown == 0 && ShieldLowering == 0) 
		{
			ShieldUp = false;
		}
	}
}
