using UnityEngine;
using System.Collections.Generic;
//using Unity.VisualScripting;

namespace Monster
{
    public class Godzilla : Monster
    {

        // Variables
        public int nextPoint;

        // Start is called before the first frame update
        void Start()
        {
            electric = false;

            GameManager.gameManager.onDayModeActivated += OnDayModeActivated;
            GameManager.gameManager.onNightModeActivated += OnNightModeActivated;
        }

        private void FixedUpdate()
        {
            //Debug.Log("Monstre qui start");
            if (targetPosition == Vector2.zero)
            {
                targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
            }

           if (nextPoint < MapManager.mapManager.pointsRepere.Count)
           {
                nextPoint = updateTargetPoint(nextPoint);
                goToTarget(targetPosition);
           }

            if (dark == true)
            {
                if (dark == true)
                {
                    sleep = true;
                }
            }

            IsDead();

        }

        public void OnDestroy()
        {
            GameManager.gameManager.onDayModeActivated -= OnDayModeActivated;
            GameManager.gameManager.onNightModeActivated -= OnNightModeActivated;
        }

        // TODO : Gozilla n'a pas de dark/night mode
        public void OnDayModeActivated()
        {
            //GetComponent<Animator>().SetBool("", false);
        }

        public void OnNightModeActivated()
        {
            //GetComponent<Animator>().SetBool("", true);
        }
    }
}
