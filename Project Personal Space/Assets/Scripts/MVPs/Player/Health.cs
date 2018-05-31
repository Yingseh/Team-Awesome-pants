using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour {
	public int PlayerHealth = 10;
	public int CurrentHealth;
	public Text HealthUI;
	Movement Mobility;
	Shooting Weapon;
	bool Damaged;
	bool IsDead;
	void Awake()
	{
		Weapon = GetComponent <Shooting> ();
		Mobility = GetComponent <Movement> ();

		CurrentHealth = PlayerHealth;
		HealthUI.text = "" + CurrentHealth;
	}
	void Update()
	{
		if (IsDead == true) 
		{
			if(Input.anyKeyDown)
			{
				SceneManager.LoadScene ("MVP Testing", LoadSceneMode.Single);
			}
		}
	}
	public void TakenDamage(int Amount)
	{
		CurrentHealth -= Amount;
		HealthUI.text = "" + CurrentHealth;


		if (CurrentHealth<=0 && !IsDead) 
		{
			Death ();	

		}
		/*if (IsDead == true) 
		{
			if(Input.anyKeyDown)
			{
				SceneManager.LoadScene ("MVP Testing", LoadSceneMode.Single);
			}
		}*/
	}
	void Death()
	{
		IsDead = true;
		Mobility.enabled = false;
		Weapon.enabled = false;

	}
	// Use this for initialization
	void Start () 
	{
		
	}


	//void OnTriggerEnter
}
