using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    if (GetComponent<PlayerController>()) {
            Destroy(gameObject.GetComponent("AIController"));
        }
	}
	
	// Update is called once per frame
	void Update () {
		//TODO AI stuff.
	}

    void Wait(float timeToWait){
        
    }

    void MoveThroughPoint(Vector2 location){
        //TODO implement here.
    }
}
