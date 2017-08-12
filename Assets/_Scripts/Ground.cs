using UnityEngine;

namespace Assets._Scripts{
    public class Ground : MonoBehaviour {

        // Use this for initializationsadasd
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update () {
		
        }

        void OnCollisionEnter2D(Collision2D collision){

            CharacterMovement characterMovement = collision.transform.GetComponent<CharacterMovement>();
            if (characterMovement) {
                characterMovement.SetCharacterState(CharacterMovement.CharacterState.ONGROUND);
                
            }
        }


        void OnCollisionExit2D(Collision2D collision) {
            CharacterMovement characterMovement = collision.transform.GetComponent<CharacterMovement>();
            if (characterMovement) {
                characterMovement.SetCharacterState(CharacterMovement.CharacterState.ONAIR);
                
            }
        }

    }
}
