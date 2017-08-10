using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour{

    public Gun gun;
    public int MaxHealth = 30;

    private int _currentHealth;


    // Use this for initialization
    void Start(){
        //Gun = GetComponentInChildren<>()
        _currentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update(){

    }

    public void PullTrigger(){
        gun.Fire();
    }

    // Destroy Object in X collisions
    void OnCollisionEnter2D(Collision2D coll){

        if (coll.gameObject.tag == "Bullet") {
            TakeDamage(10);
        }
    }
    
    void TakeDamage(int damageToApply){
        _currentHealth -= damageToApply;
        if (_currentHealth <= 0) {
            Destroy(gameObject);
        }
    }
}
