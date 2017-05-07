using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archerBlack : MonoBehaviour {

	public GameObject moveplatfrom;
	public GameObject myArcher;
	public float speed;
	public Transform currentPoint;
	public Transform[] points;
	public Vector3 ScaleInX;

	public int selectPoints;
	// Use this for initialization
	void Start ()
	{
		myArcher = GameObject.Find ("blackArchEnemy");
		currentPoint = points [selectPoints];
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		moveplatfrom.transform.position = Vector3.MoveTowards (moveplatfrom.transform.position, currentPoint.position, Time.deltaTime * speed);
		Vector3 ScaleInX = myArcher.transform.localScale;
		Vector3 ScaleInXorg = myArcher.transform.localScale;

		if(moveplatfrom.transform.position == currentPoint.position)
		{
			selectPoints++;
			ScaleInXorg.x *= -1;
			myArcher.transform.localScale = ScaleInXorg;


			if(selectPoints == points.Length)
			{
				selectPoints = 0;
				ScaleInX.x *= -1;
				myArcher.transform.localScale = ScaleInX;
			}

			currentPoint = points [selectPoints];

		}
	}
}
