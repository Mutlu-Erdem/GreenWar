using UnityEngine;

namespace Assets._Scripts {
    public class CharacterMovement : MonoBehaviour {

        public enum CharacterState {ONAIR,MOVING,STOPED,ONGROUND}

        // Constructors
        public bool faceRight = true;
        public Vector3 ScaleInX;
        public int maxMovementSpeed = 60;   
        public float acceleration = 5;
        public float jumpSpeed = 10;
        public float jumpBlockingSpeed = 30;

        private Animator _animator;
        private Rigidbody2D _rigidbody;
        private bool _isOnAir;

        private CharacterState _state;

        // Use this for initialization
        void Start() {
            _animator = GetComponent<Animator>();
            _animator.ResetTrigger("isMove");
            _animator.SetTrigger("NotMove");
            _rigidbody = GetComponent<Rigidbody2D>();
            _state = CharacterState.STOPED;
        }



        //Movement in X direction
        public void MoveInX(int setXDirection) {

           

            if (_state == CharacterState.ONGROUND) {
                if (_rigidbody.velocity.x < maxMovementSpeed && _rigidbody.velocity.x > -maxMovementSpeed) {
                    _rigidbody.velocity += new Vector2(setXDirection * acceleration, 0);
                }
                _animator.SetBool("isWalking", true);

                if (faceRight == false && setXDirection < 0) {
                    ScaleRight(true);
                } else if (faceRight == true && setXDirection > 0) {
                    ScaleRight(false);
                }
            } else if (_state == CharacterState.ONAIR) {
                if (_rigidbody.velocity.x > 0 && setXDirection < 0) {
                    _rigidbody.velocity = Vector2.zero;
                } else if (_rigidbody.velocity.x < 0 && setXDirection > 0) {
                    _rigidbody.velocity = Vector2.zero;
                }
            }

        }

        //Movement Y direction.
        public void Jump() {
            if (_state == CharacterState.ONGROUND) {
                _animator.SetTrigger("isAir");

                if (_rigidbody.velocity.x > 0) {
                    _rigidbody.velocity += new Vector2(-jumpBlockingSpeed, jumpSpeed);
                } else if(_rigidbody.velocity.x < 0) {
                    _rigidbody.velocity += new Vector2(jumpBlockingSpeed, jumpSpeed);
                }
                
                _state = CharacterState.ONAIR;
            }
        }

        public void StopMoving() {
            if (_state == CharacterState.ONGROUND) {
                _rigidbody.velocity = Vector2.zero;
                
            }
        }

        //Scale character in Right
        private void ScaleRight(bool facePosition) {
            Vector3 ScaleInX = transform.localScale;
            ScaleInX.x *= -1;
            transform.localScale = ScaleInX;
            faceRight = facePosition;
        }

        public void SetCharacterState(CharacterState stateToSet) {
            _state = stateToSet;
        }
       //Spawn
        public void SpawnConditions(bool faceRightToSet, int movementSpeedtoSet) {
            this.faceRight = faceRightToSet;
            this.maxMovementSpeed = movementSpeedtoSet;
        }
    }
}
