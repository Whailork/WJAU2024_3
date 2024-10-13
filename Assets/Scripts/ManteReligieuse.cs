using UnityEngine;

namespace Monster
{
    public class ManteReligieuse : Monster
    {
        public int nextPoint;
        //public ManteReligieuse() { life = 150; power = 50; sleep = false; electric = true; }

        // Start is called before the first frame update
        void Start()
        {
            GameManager.gameManager.onDayModeActivated += OnDayModeActivated;
            GameManager.gameManager.onNightModeActivated += OnNightModeActivated;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            IsDead();

            float speed = GetComponent<Rigidbody2D>().velocity.magnitude;
            GetComponent<Animator>().SetFloat("Speed", speed);
            GetComponent<Animator>().SetBool("Sleep", sleep);
            GetComponent<Animator>().SetInteger("Life", life);
            GetComponent<Animator>().SetBool("Dark", dark);
            GetComponent<Animator>().SetBool("Electric", electric);

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

        public void OnDayModeActivated()
        {
            GetComponent<Animator>().SetBool("Dark", false);
        }

        public void OnNightModeActivated()
        {
            GetComponent<Animator>().SetBool("Dark", true);
        }

        public void OnDestroy()
        {
            GameManager.gameManager.onDayModeActivated -= OnDayModeActivated;
            GameManager.gameManager.onNightModeActivated -= OnNightModeActivated;
        }
    }
}
