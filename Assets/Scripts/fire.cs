using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {

	public GameObject myBox;
	public BoxCollider2D boxCollider;

	// Find gameObject and initialize it.
	void Start ()
	{
		//myBox = GameObject.Find ("Box");
	}


	//Destroy object itself in every collision
	void OnCollisionEnter2D(Collision2D coll)
	{

		if (coll.collider == true)
		{
			Destroy (this.gameObject);
		}

	}
}
