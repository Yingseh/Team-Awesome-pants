using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Winning : MonoBehaviour {
	public Text WinState;
	public GameObject Finished;
	Spawning Spawner;
	void Awake()
	{
		Finished.SetActive (false);
		Spawner = GetComponent<Spawning>();
	}
	public void Trained()
	{
		Finished.SetActive (true);
		WinState.text = "Training over. Return to quaters.";
		//Finished.enabled = true;
	}
	public void OnSubmit()
	{
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
	void Update()
	{
		if (PuaseMenu.TimeOut == true) 
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
		if (Spawner.HasWon == true ) {
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			Spawner.enabled = false;
			WinState.text = "Training over. Return to quaters.";
		} 
		else if(PuaseMenu.TimeOut == false)
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

}
