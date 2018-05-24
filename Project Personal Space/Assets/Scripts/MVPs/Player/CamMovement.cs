using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour {	
	public float MouseSense;
	private float XAxisClamp = 0.0f;

	void FixedUpdate () 
	{
		CamLook ();

	}

	void CamLook()
	{   
		float LookUp = Input.GetAxis ("Mouse Y");
		float RotAmount = LookUp * MouseSense;
		XAxisClamp -= RotAmount;
		Vector3 UpDown = transform.rotation.eulerAngles;
		UpDown.z = 0;
		UpDown.x -= RotAmount;

		if(XAxisClamp > 90)
		{
			XAxisClamp = 90;
			UpDown.x = 90;
		}
		else if(XAxisClamp < -90)
		{
			XAxisClamp = -90;
			UpDown.x = 270; 
		}
		transform.rotation = Quaternion.Euler (UpDown);
	}
}
