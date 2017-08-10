using UnityEngine;

namespace Assets._Scripts{
    public class MovingPlatform : MonoBehaviour{

        public float distanceX = 20;
        public float distanceY = 20;

        public bool isMovementHorizontal;
        public bool isPlatformHorizontal;

        private float _startingLocationX;
        private float _startingLocationY;
        private bool _isgoingLeft;



        // Use this for initialization
        void Start(){
            _startingLocationX = transform.position.x;
            _startingLocationY = transform.position.y;

            if (isPlatformHorizontal) {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else {
                transform.rotation = Quaternion.Euler(0,0,90);
            }
        }

        // Update is called once per frame
        void Update(){
            if (isMovementHorizontal) {
                MoveHorizontally();
                print("horizontal working.");
            }
            else {
                MoveVertically();
            }
        }

        private void MoveHorizontally(){
            if (_isgoingLeft) {
                transform.position += Vector3.left;
            }
            else {
                transform.position += Vector3.right;
            }

            if (transform.position.x - _startingLocationX > distanceX) {
                print("asdasd");
                _isgoingLeft = true;
            }

            if (transform.position.x - _startingLocationX < -distanceX) {
                print("-----dasdasd");
                _isgoingLeft = false;
            }
        }

        private void MoveVertically(){
            if (_isgoingLeft) {
                transform.position += Vector3.down;
            }
            else {
                transform.position += Vector3.up;
            }

            if (transform.position.y - _startingLocationY > distanceY) {
                print("asdasd");
                _isgoingLeft = true;
            }

            if (transform.position.y - _startingLocationY < -distanceY) {
                print("-----dasdasd");
                _isgoingLeft = false;
            }
        }
    }
}
