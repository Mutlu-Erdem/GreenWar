using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHorizontalScript : MonoBehaviour
{

	public GameObject moveHorizontalObject;
	public float speed;
	public Transform currentPoint;
	public Transform[] points;

	public int selectPoints;
	// Use this for initialization
	void Start ()
	{
		currentPoint = points [selectPoints];
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		moveHorizontalObject.transform.position = Vector3.MoveTowards (moveHorizontalObject.transform.position, currentPoint.position, Time.deltaTime * speed);

		if(moveHorizontalObject.transform.position == currentPoint.position)
		{
			selectPoints++;

			if(selectPoints == points.Length)
			{
				selectPoints = 0;
			}

			currentPoint = points [selectPoints];
		}
	}
}
