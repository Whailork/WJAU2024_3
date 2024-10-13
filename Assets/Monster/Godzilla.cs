using UnityEngine;
using System.Collections.Generic;

namespace Monster
{
    public class Godzilla : Monster
    {
        //public Godzilla() { life = 100; power = 20; sleep = false; electric = false; }

        // Variables
        public int nextPoint;
        public Animator animator;

        // Start is called before the first frame update
        void Start()
        {
            //animator = GetComponent<Animator>();
            //animator.Play("Idle_Godzilla");

            electric = false;

            nextPoint = 0;
        }

        private void FixedUpdate()
        {
            GetComponent<Rigidbody2D>().velocity = move;

            Debug.Log("Monstre qui start");
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
