using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    private CharacterMovement _characterMovementObject;
    private Character _character;

    // Use this for initialization
    void Start(){
        _characterMovementObject = GetComponent<CharacterMovement>();
        _character = GetComponent<Character>();
        print(_characterMovementObject);

    }

    // Update is called once per frame
    void Update(){

        if (Input.GetKey(KeyCode.W)) {
            _characterMovementObject.Jump();
        }
        
        else if (Input.GetKey(KeyCode.A)) {
            _characterMovementObject.MoveInX(-1);
        }

        else if (Input.GetKey(KeyCode.D)) {
            _characterMovementObject.MoveInX(1);
        }
        if (Input.GetMouseButtonDown(0)) {
            _character.PullTrigger();
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
