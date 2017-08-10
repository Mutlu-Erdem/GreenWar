using UnityEngine;

namespace Assets._Scripts{
    public class CharacterMovement : MonoBehaviour {

        // Constructors
        public bool faceRight = true;
        public Vector3 ScaleInX;
        public int movementSpeed = 100;

        private Animator _animator;

        // Use this for initialization
        void Start ()
        {
            _animator = GetComponent<Animator>();
            _animator.ResetTrigger ("isMove");
            _animator.SetTrigger ("NotMove");

        }

        //Spawn
        public void SpawnConditions(bool faceRightToSet, int movementSpeedtoSet)
        {
            this.faceRight = faceRightToSet;
            this.movementSpeed = movementSpeedtoSet;
        }


        //Movement in X direction
        public void MoveInX(int setXDirection)
        {
		
            _animator.SetBool ("isWalking",true);

            if (faceRight == false && setXDirection < 0)
            {
                ScaleRight (true);
            }

            else if (faceRight == true && setXDirection > 0)
            {
                ScaleRight (false);
            }

            transform.Translate (new Vector3(setXDirection * movementSpeed * Time.deltaTime,0,0));
        }


        //Movement in X direction
        public void Jump()
        {
            _animator.SetTrigger ("isAir");
            transform.Translate (Vector3.up  * movementSpeed * Time.deltaTime);
        }

        // Character Idle
        public void Idle()
        {
            _animator.SetBool ("isWalking",false);
        }


        //Scale character in Right
        private void ScaleRight (bool facePosition)
        {
            Vector3 ScaleInX = transform.localScale;
            ScaleInX.x *= -1;
            transform.localScale = ScaleInX;
            faceRight = facePosition;
        }
    }
}
