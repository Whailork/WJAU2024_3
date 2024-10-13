using UnityEngine;

namespace Monster
{
    public class Serpent : Monster
    {
        public int nextPoint;
        public Animator animator;
        // Start is called before the first frame update
        void Start()
        {

            animator = GetComponent<Animator>();
            animator.Play("Idle Serpent");
            //electric = false;
        }

        // Update is called once per frame
        void FixedUpdate()
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


    }
}
