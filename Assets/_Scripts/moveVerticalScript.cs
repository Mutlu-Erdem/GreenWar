using UnityEngine;

namespace Assets._Scripts{
    public class moveVerticalScript : MonoBehaviour {

        public GameObject moveVerticalObject;
        public float speed;
        public Transform currentPoint;
        public Transform[] points;

        public int selectPoints;
        // Use this for initialization
        void Start ()
        {
            currentPoint = points [selectPoints];
        }

        // Update is called once per frame
        void FixedUpdate ()
        {
            moveVerticalObject.transform.position = Vector3.MoveTowards (moveVerticalObject.transform.position, currentPoint.position, Time.deltaTime * speed);

            if(moveVerticalObject.transform.position == currentPoint.position)
            {
                selectPoints++;

                if(selectPoints == points.Length)
                {
                    selectPoints = 0;
                }

                currentPoint = points [selectPoints];
            }
        }
    }
}
