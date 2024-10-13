using UnityEngine;

namespace Monster
{
    public class Insecte : Monster
    {
        public int nextPoint;
        // Start is called before the first frame update
        void Start()
        {
            GameManager.gameManager.onDayModeActivated += OnDayModeActivated;
            GameManager.gameManager.onNightModeActivated += OnNightModeActivated;
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

        public void OnDayModeActivated()
        {
            GetComponent<Animator>().SetBool("Dark", false);
        }

        public void OnNightModeActivated()
        {
            GetComponent<Animator>().SetBool("Dark", true);
        }
    }
}
