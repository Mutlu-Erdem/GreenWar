using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour {

	// Constructors
	public bool faceRight = true;
	public Vector3 ScaleInX;
	private Animator animator;
	public int movementSpeed = 100;

	// Use this for initialization
	void Start ()
	{
		animator = GetComponent<Animator>();
		animator.ResetTrigger ("isMove");
		animator.SetTrigger ("NotMove");

	}

	//Spawn
	public void spawnConditions(bool faceRightToSet, int movementSpeedtoSet)
	{
		this.faceRight = faceRightToSet;
		this.movementSpeed = movementSpeedtoSet;
	}


	//Movement in X direction
	public void moveInX(int setXDirection)
	{
		
		animator.SetBool ("isWalking",true);

		if (faceRight == false && setXDirection < 0)
		{
			scaleRight (true);
		}

		else if (faceRight == true && setXDirection > 0)
		{
			scaleRight (false);
		}

		transform.Translate (new Vector3(setXDirection * movementSpeed * Time.deltaTime,0,0));
	}


	//Movement in X direction
	public void jump()
	{
		animator.SetTrigger ("isAir");
		transform.Translate (Vector3.up  * movementSpeed * Time.deltaTime);
	}

	// Character Idle
	public void Idle()
	{
		animator.SetBool ("isWalking",false);
	}


	//Scale character in Right
	private void scaleRight (bool facePosition)
	{
		Vector3 ScaleInX = transform.localScale;
		ScaleInX.x *= -1;
		transform.localScale = ScaleInX;
		faceRight = facePosition;
	}
}
