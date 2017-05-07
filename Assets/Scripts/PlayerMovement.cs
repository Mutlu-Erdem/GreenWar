using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public bool faceRight;
	public int movementSpeed = 100;
	public Vector3 ScaleInX;
	private Animator animator;

	private characterMovement characterMovementObject; 


	// Use this for initialization
	void Start ()
	{
		faceRight = true;
		animator = GetComponent<Animator>();
		animator.ResetTrigger ("isMove");
		animator.SetTrigger ("NotMove");
		characterMovementObject = GetComponent <characterMovement> ();

	}

	// Update is called once per frame
	void FixedUpdate ()
	{

		if (Input.GetKey (KeyCode.W))
		{
			characterMovementObject.jump ();
		}

		//GetComponent<Animator> ().speed = 800;
		if (Input.GetKey (KeyCode.A))
		{	
			characterMovementObject.moveInX (-1);
		}
			
		else if(Input.GetKey (KeyCode.D))
		{	
			characterMovementObject.moveInX (1);
		}

		else
		{
			characterMovementObject.Idle ();
		}


	}

	void OnCollisionEnter2D(Collision2D coll)
	{

		if(coll.transform.tag == "movingPlatform")
		{
			//onPlatform.transform.
			transform.parent = coll.transform;
		}
	}

	void OnCollisionExit2D(Collision2D coll)
	{

		if(coll.transform.tag == "movingPlatform")
		{
			//onPlatform.transform.
			transform.parent = null;
		}
	}



}
