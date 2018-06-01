using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PuaseMenu : MonoBehaviour {
	public static bool TimeOut = false;
	public GameObject PauseUI;
	// Use this for initialization
	void Start () {
		PauseUI.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			if (TimeOut) 
			{
				Resume ();
			} 
			else
			{
				Pause ();
			}
		}	
	}
	void Resume()
	{
		PauseUI.SetActive (false);
		Time.timeScale = 1f;
		TimeOut = false;
	}
	void Pause ()
	{
		PauseUI.SetActive (true);
		Time.timeScale = 0f;
		TimeOut = true;
	
	}
	public void OnMenuClick()
	{
		SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
	}
	public void OnQuitClick()
	{
		Application.Quit ();
	}
}
