using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour{

    public float distance = 75;

    private float _startingLocation;
    private bool _isgoingLeft;

    // Use this for initialization
    void Start (){
        _startingLocation = transform.position.x;
    }
	
	// Update is called once per frame
	void Update () {
	    if (_isgoingLeft) {
	        transform.Translate(Vector3.left);
	    }
	    else {
	        transform.Translate(Vector3.right);
	    }
      //  print("transform : " + transform.position.x + " starting location: " + _startingLocation);
	    if (transform.position.x - _startingLocation > distance) {
	        print("asdasd");
	        _isgoingLeft = true;
	    }

	    if (transform.position.x - _startingLocation < -distance) {
	        print("-----dasdasd");
            _isgoingLeft = false;
        }


    }
}
