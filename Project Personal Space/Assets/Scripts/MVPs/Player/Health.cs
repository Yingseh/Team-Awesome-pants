using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : EnemyMovement {
	public int PlayerHealth = 10;
	public Text HealthUI;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		HealthUI.text = "" + PlayerHealth;
		if (DesAccuracy <= 2) 
		{
			
			CheckHealth ();
		}
	}
	public void CheckHealth () 
	{
		if (PlayerHealth <=0) 
		{
			Destroy (gameObject);
		}	

	}
	//void OnTriggerEnter
}
