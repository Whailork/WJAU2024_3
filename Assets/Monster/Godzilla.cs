using UnityEngine;
using System.Collections.Generic;

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

            if (targetPosition == Vector2.zero)
            {
                targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
            }

            if (nextPoint < MapManager.mapManager.pointsRepere.Count)
            {
                nextPoint = updateTargetPoint(nextPoint);
                goToTarget(targetPosition);
            }

            float speed = GetComponent<Rigidbody2D>().velocity.magnitude;
            GetComponent<Animator>().SetFloat("Speed", speed);
            GetComponent<Animator>().SetBool("Sleep", sleep);
            GetComponent<Animator>().SetInteger("Life", life);
            GetComponent<Animator>().SetBool("Dark", dark);

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
