using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
	public float AttackSpeed = 0.05f;
	public int AttackStrength = 1;

	GameObject Player;
	Health Playerhealth;

	bool TargetInRange;
	float AttackCD;
	void Awake()
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
		Playerhealth = Player.GetComponent<Health> ();

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == Player) 
		{
			TargetInRange = true;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == Player) 
		{
			TargetInRange = false;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		AttackCD += Time.deltaTime;
		if (AttackCD >= AttackSpeed && TargetInRange) 
		{
		
			Strike ();
		}

	}
	void Strike()
	{
		AttackCD = 0f;
		if (Playerhealth.CurrentHealth > 0) 
		{
			Playerhealth.TakenDamage (AttackStrength);
		}
	}
}
