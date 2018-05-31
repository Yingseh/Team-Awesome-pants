using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour {
	public int PlayerHealth = 10;
	public Text HealthUI;
	public float AttackSpeed;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		CheckHealth();	
		HealthUI.text = "" + PlayerHealth;


	}
	void OnTriggerStay(Collider Other)
	{
		if (Other.CompareTag("Enemy") ) 
		{
			;	
			StartCoroutine (Attack());
			Debug.Log ("strike");
		
		}

	}
	IEnumerator Attack()
	{

		yield return new WaitForSeconds (AttackSpeed);
		Debug.Log ("hit");
		PlayerHealth--;
	
		yield break;
	}
	public void CheckHealth () 
	{
	/*	Debug.Log ("update health");
		HealthUI.text = "" + PlayerHealth;*/
		Debug.Log ("check");
		if (PlayerHealth <=0) 
		{
			SceneManager.LoadScene ("MVP Testing", LoadSceneMode.Single);
		}	

	}

	//void OnTriggerEnter
}
