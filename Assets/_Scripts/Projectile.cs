using UnityEngine;

namespace Assets._Scripts{
    public class Projectile : MonoBehaviour{

        public GameObject myBox;
        public BoxCollider2D boxCollider;

        // Find gameObject and initialize it.
        void Start(){
            //myBox = GameObject.Find ("Box");
        }


        //Destroy object itself in every collision
        void OnCollisionEnter2D(Collision2D coll){

            if (coll.collider == true) {
                Destroy(this.gameObject);
            }

        }
    }
}
