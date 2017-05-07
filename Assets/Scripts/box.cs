using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
	int count = 0;
	public GameObject bulletPrefab;


	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


	// Destroy Object in X collisions
	void OnCollisionEnter2D(Collision2D coll)
	{
		
		if(coll.gameObject.tag == "Bullet")
		{
			count++;
			Debug.Log (count);
			if(count == 3)
			{
				Destroy (this.gameObject);
			}

		}
			
	}


}
