using UnityEngine;

namespace Assets._Scripts{
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
}
