using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spawning : MonoBehaviour 
{
	public Text WinState;
	public Button Finished;
	public enum SpawnState {Spawning, Waiting, Counting};
	GameObject Enemy;
	Winning Won;
	[System.Serializable]
	public class Waves
	{
		public string CWave;
		//public Transform enemy;
		public int Count;
		public float Rate;
	}	
	public Waves[] AWave;
	public Transform[] Gates;
	int NWave = 0;

	public float TBWaves = 5f;
	public float WaveCD;
	float ElifeCheck = 1f;
	SpawnState state = SpawnState.Counting;

	void Start ()
	{
		WaveCD = TBWaves;
		Enemy = Resources.Load ("Enemy") as GameObject;
		Won = GetComponent <Winning> ();
	}

	void Update ()
	{
		if (state == SpawnState.Waiting) 
		{
			if (!EnemyLS ()) {
				//send in more
				SendMore();
			} else 
			{
				return;
			}
		}
		if (WaveCD <= 0)
		{
			if (state != SpawnState.Spawning) {
				StartCoroutine (WaveSpawning (AWave [NWave]));
			} 
		}
			else
			{
				WaveCD -= Time.deltaTime;	
			}
	}
	void SendMore()
	{
		state = SpawnState.Counting;
		WaveCD = TBWaves;

		if (NWave + 1 > AWave.Length - 1) {
		
			Trained ();
			//NWave = 0;
			Debug.Log ("Reversing Time. Trying again...");
		} 
		else 
		{
			NWave++;
		}
	}
	public void Trained()
	{
//		Finished.enabled = true;
		WinState.text = "Training over. Return to quaters.";
		//Finished.enabled = true;
	}
	bool EnemyLS()
	{
		ElifeCheck -= Time.deltaTime;
		if (ElifeCheck <= 0f) {
			ElifeCheck = 1f;
		
			if (GameObject.FindGameObjectWithTag ("Enemy") == null) {
				return false;
			}
		}
		return true;
	}
	IEnumerator WaveSpawning (Waves _Waves)
	{
		state = SpawnState.Spawning;

		for (int i = 0; i < _Waves.Count; i++) 
		{
			SpawningEnemy (Enemy);
			yield return new WaitForSeconds (1f / _Waves.Rate);
		}
	
		state = SpawnState.Waiting;

		yield break;
	}
	void SpawningEnemy(GameObject _Enemy)
	{
		//spawn enemy
		Transform _Sp = Gates [Random.Range(0, Gates.Length)];
		GameObject Portal = Instantiate(Enemy) as GameObject;
		Portal.transform.position = _Sp.position;
	}

}
