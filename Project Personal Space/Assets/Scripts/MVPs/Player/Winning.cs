using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Winning : MonoBehaviour {
	public Text WinState;
	public Button Finished;
	public void Trained()
	{
		Finished.enabled = true;
		WinState.text = "Training over. Return to quaters.";
		//Finished.enabled = true;
	}
	public void OnSubmit()
	{
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}

}
