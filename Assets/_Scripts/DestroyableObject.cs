using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour{
    
    public int Health = 30;
 
    // Use this for initialization
    void Start(){

    }

    // Update is called once per frame
    void Update(){

    }

    private void TakeDamage(int damage){
        Health -= damage;
        if (Health <= 0) {
            Destroy(this.gameObject);
        }
    }

    // Destroy Object in X collisions
    void OnCollisionEnter2D(Collision2D coll){

        if (coll.gameObject.tag == "Bullet") {
            TakeDamage(10);
        }
    }
}
