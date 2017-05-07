using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{

	public GameObject tracker;
	// Use this for initialization
	void Start ()
	{
		tracker = GameObject.Find ("tracker");
	}
	
	// Follow player within limited X and Y axises.
	void LateUpdate ()
	{
		transform.position = new Vector3 (Mathf.Clamp (tracker.transform.position.x, -401, 8), Mathf.Clamp (tracker.transform.position.y,-40, -20), transform.position.z);
		//transform.position = new Vector3 (transform.position.y, Mathf.Clamp(transform.position.x, -401, 8), transform.position.z);
	}
}
