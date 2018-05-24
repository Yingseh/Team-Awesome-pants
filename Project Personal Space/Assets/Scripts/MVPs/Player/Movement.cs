using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	//Player
	public float Speed = 10f;
	public float rotateSpeed = 70f;
	public Rigidbody PlayerBody;
	public Transform PlayerPos;
	//camara


	// Use this for initialization
	void Start () 
	{
		PlayerBody = GetComponent<Rigidbody> ();	

	}
	void Update()
	{
		
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;


	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{  
		//player movment.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float rotateRound = Input.GetAxis ("Mouse X");
		Vector3 PMovement = new Vector3 (moveHorizontal, 0.0f, moveVertical); 
		Vector3 Protation = new Vector3 (0.0f,rotateRound, 0.0f);
		transform.Translate(PMovement * Speed * Time.deltaTime);
		transform.Rotate(Protation * rotateSpeed * Time.deltaTime);


	
	}


}
