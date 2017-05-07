using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBullet : MonoBehaviour
{

	public GameObject Bullet_Emitter;
	public GameObject Bullet;

	public float Bullet_Force;



	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		

		if(Input.GetMouseButtonDown(0))
		{

			/*How to access another scripts variable*/
			GameObject player = GameObject.Find ("Green");
			PlayerMovement moveScript = player.GetComponent<PlayerMovement>();


			GameObject Temp_Bullet;
			Temp_Bullet = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

			Temp_Bullet.transform.Rotate (Vector3.left * 90);

			Rigidbody2D Temp_Rigid;
			Temp_Rigid = Temp_Bullet.GetComponent<Rigidbody2D>();
			 

			if(moveScript.faceRight == true)
			{
				Temp_Rigid.AddForce (transform.right * Bullet_Force);
			}
			else if(moveScript.faceRight == false)
			{
				Temp_Rigid.AddForce (transform.right * -1 * Bullet_Force);
			}

			Destroy (Temp_Bullet, 5.0f);
		}
			
	}


}
