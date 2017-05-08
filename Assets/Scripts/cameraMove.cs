using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{

	public GameObject tracker;
	// Use this for initialization
	void Start ()
	{

	}
	
	// Follow player within limited X and Y axises.
	void FixedUpdate ()
	{
		transform.position = new Vector3 (tracker.transform.position.x, Mathf.Clamp(tracker.transform.position.y, -401, 8), transform.position.z);
		print ("camera position: " + transform.position.ToString ());

		//transform.position = new Vector3 (tracker.transform.position.x, Mathf.Clamp(tracker.transform.position.y, -401, 8), tracker.transform.position.z);
	}
}
