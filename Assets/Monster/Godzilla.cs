//using System.Linq;
using UnityEngine;

namespace Monster
{
    public class Godzilla : Monster
    {

        //public Godzilla() { life = 100; power = 20; sleep = false; electric = false; }

        // Variables
        public int nextPoint;

        /*
        void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("CollisionEnter_godzilla");
        }*/

        // Start is called before the first frame update
        void Start()
        {

            electric = false;

            nextPoint = 0;
        }

        private void FixedUpdate()
        {
            if (targetPosition == Vector2.zero)
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


        public void IfdarkMode(bool dark)
        {
            if (dark == true)
            {
                if (dark == true)
                {
                    sleep = true;
                }
            }
        }
    }
}
