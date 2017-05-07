using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public bool faceRight;
	public int movementspeed = 100;
	public Vector3 ScaleInX;
	private Animator animator;


	// Use this for initialization
	void Start ()
	{
		faceRight = true;
		animator = GetComponent<Animator>();
		animator.ResetTrigger ("isMove");
		animator.SetTrigger ("NotMove");

	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		animator.ResetTrigger ("isMove");
		animator.SetTrigger ("NotMove");

		//GetComponent<Animator> ().speed = 800;
		if (Input.GetKey (KeyCode.A))
		{	
			animator.ResetTrigger ("NotMove");
			animator.SetTrigger ("isMove");
			if (faceRight == true)
			{
				Vector3 ScaleInX = transform.localScale;
				ScaleInX.x *= -1;
				transform.localScale = ScaleInX;
				faceRight = false;
			}
			transform.Translate (Vector3.left * movementspeed * Time.deltaTime);
		}


		if(Input.GetKey (KeyCode.D))
		{		
			animator.SetTrigger ("isMove");
			animator.ResetTrigger ("NotMove");
			if (faceRight == false)
			{
				Vector3 ScaleInX = transform.localScale;
				ScaleInX.x *= -1;
				transform.localScale = ScaleInX;
				faceRight = true;
			}
			transform.Translate (Vector3.right * movementspeed * Time.deltaTime);

		}


		if (Input.GetKey (KeyCode.W))
		{
			animator.SetTrigger ("isAir");
			transform.Translate (Vector3.up  * movementspeed * Time.deltaTime);
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
