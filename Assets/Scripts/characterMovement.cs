using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour {

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

	public void spawnConditions(bool faceRightToSet, int movementSpeedtoSet)
	{
		this.faceRight = faceRightToSet;
		this.movementSpeed = movementSpeedtoSet;
	}

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

	public void jump()
	{
		animator.SetTrigger ("isAir");
		transform.Translate (Vector3.up  * movementSpeed * Time.deltaTime);
	}

	public void Idle()
	{
		animator.SetBool ("isWalking",false);
	}


	private void scaleRight (bool facePosition)
	{
		Vector3 ScaleInX = transform.localScale;
		ScaleInX.x *= -1;
		transform.localScale = ScaleInX;
		faceRight = facePosition;
	}
}
