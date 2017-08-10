using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    private CharacterMovement _characterMovementObject;


    // Use this for initialization
    void Start(){
        _characterMovementObject = GetComponent<CharacterMovement>();
        print(_characterMovementObject);

    }

    // Update is called once per frame
    void Update(){

        if (Input.GetKey(KeyCode.W)) {
            _characterMovementObject.Jump();
        }
        
        if (Input.GetKey(KeyCode.A)) {
            _characterMovementObject.MoveInX(-1);
        }

        else if (Input.GetKey(KeyCode.D)) {
            _characterMovementObject.MoveInX(1);
        }
    }

    void OnCollisionEnter2D(Collision2D coll){ //TODO delete this method.

        if (coll.transform.tag == "movingPlatform") {
            //onPlatform.transform.
            transform.parent = coll.transform;
        }
    }

    void OnCollisionExit2D(Collision2D coll){   //TODO delete this method.

        if (coll.transform.tag == "movingPlatform") {
            //onPlatform.transform.
            transform.parent = null;
        }
    }

}
