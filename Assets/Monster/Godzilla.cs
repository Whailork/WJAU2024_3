//using System.Linq;
using UnityEngine;

namespace Monster
{
    public class Godzilla : Monster
    {

        //public Godzilla() { life = 100; power = 20; sleep = false; electric = false; }

        // Variables
        public int nextPoint;

        // Start is called before the first frame update
        void Start()
        {

            electric = false;

            nextPoint = 0;
        }

        private void FixedUpdate()
        {
            if(targetPosition == Vector2.zero)
            {
                targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
            }

            if (nextPoint < MapManager.mapManager.pointsRepere.Count)
            {
                nextPoint = updateTargetPoint(nextPoint);
                goToTarget(targetPosition);
            }

        }

        void Update()
        {


        }

        public override void IfdarkMode(bool dark)
        {
            if (dark == true)
            {
                sleep = true;
            }
        }

        // Enlever car faisant faire des jumps durant le d�placement
        /*
    public Vector2 Seek(Vector2 target)
    {
        Vector2 desiredVelocity = target - (Vector2)transform.position;
        desiredVelocity.Normalize();
        desiredVelocity *= speed;

        Vector2 steering = desiredVelocity - velocity;
        steering = Vector2.ClampMagnitude(steering, speed);

        return steering;
    }
    */



    }
}
