using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

	public GameObject tracker;
	// Use this for initialization
	void Start ()
	{

	}
	
	// Follow player within limited X and Y axises.
	void FixedUpdate ()
	{
		transform.position = new Vector3 (Mathf.Clamp(tracker.transform.position.x, -360, 8), Mathf.Clamp(tracker.transform.position.y, -80, -50), transform.position.z);

		/* Debug for main camera position !!! NOT TRACER /*
		//print ("camera position: " + transform.position.ToString ());
		*/
	}
}
