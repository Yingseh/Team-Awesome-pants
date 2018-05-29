using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {
	public Rigidbody PlayerHand;
	//public  Rigidbody [] Items;
	private Vector3 MoveTo;
	private Quaternion RotateTo;
	public float ArmsLength = 5f;
	void Start()
	{
		
		PlayerHand = GetComponent<Rigidbody> ();
		RotateTo = Quaternion.Euler(new Vector3 (45, 0, 0));

	}
	void FixedUpdate()
	{
		MoveTo = new Vector3 (PlayerHand.position.x + ArmsLength, PlayerHand.position.y + ArmsLength, PlayerHand.position.z + ArmsLength);

	}

	void OnTriggerStay(Collider other)
	{ 
		if (other.CompareTag("PickUp"))
		{
			//Items = new Rigidbody[other.GetComponent<Rigidbody>()];
			//Item = other.GetComponent<Rigidbody>();
			Debug.Log ("There is something to pick up");
			if (Input.GetKey(KeyCode.E)) 
			{
				other.transform.parent = PlayerHand.transform;
				/*Item = other.GetComponent<Collider>();
				Item;*/
				Debug.Log ("That should have done it");
				other.attachedRigidbody.MovePosition(MoveTo);
				other.attachedRigidbody.MoveRotation(RotateTo);
				other.attachedRigidbody.constraints = RigidbodyConstraints.FreezeAll;
				//other.tag.Replace ("PickUp", "Held"); 
		}
			/*if (Items.CompareTag ("Held")) {
				Items.position = MoveTo;
			} */
		}
	}

}
