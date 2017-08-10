using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour{

    public bool IsControlledByAI = true;
    public Gun gun;
    public int MaxHealth = 30;

    private int _currentHealth;


    // Use this for initialization
    void Start(){
        //Gun = GetComponentInChildren<>()
        _currentHealth = MaxHealth;
        CreateControllerComponent();
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

    private void CreateControllerComponent(){
        if (IsControlledByAI) {
            gameObject.AddComponent<AIController>();
        }
        else {
            gameObject.AddComponent<PlayerController>();
        }
    }
}
