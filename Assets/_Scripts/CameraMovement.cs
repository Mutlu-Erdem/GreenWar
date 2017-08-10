using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour{

    public GameObject leftEdge;
    public GameObject rightEdge;

    private float _leftEdgeXLocation;
    private float _rightEdgeXLocation;
    private float _cameraBoundry;

    public GameObject tracker;
    // Use this for initialization
    void Start(){
        //TODO implement comment for feature.
        _leftEdgeXLocation = leftEdge.transform.position.x;
        _rightEdgeXLocation = rightEdge.transform.position.x;

        // Make sure camera starts from left boundry.
        _cameraBoundry = transform.position.x - _leftEdgeXLocation;

        _leftEdgeXLocation += _cameraBoundry;
        _rightEdgeXLocation -= _cameraBoundry;
    }

    // Follow player within limited X and Y axises.
    void FixedUpdate(){
        transform.position =
            new Vector3(Mathf.Clamp(tracker.transform.position.x, _leftEdgeXLocation, _rightEdgeXLocation),
                Mathf.Clamp(tracker.transform.position.y, -80, -50), transform.position.z);



        /* Debug for main camera position !!! NOT TRACER /*
        //print ("camera position: " + transform.position.ToString ());
        */
    }

}