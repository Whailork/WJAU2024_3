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
            maxlife = life; 
            GameManager.gameManager.onDayModeActivated += OnDayModeActivated;
            GameManager.gameManager.onNightModeActivated += OnNightModeActivated;
        }

        public void FixedUpdate()
        {

            IfSleep(sleep);
            IsDead();
            float speed = 1f;
            Debug.Log(speed);
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

        public bool DarkMode(bool d)
        {
            if (d == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IfSleep(bool s)
        {
            Debug.Log("Godzilla s endort");
            if (s == true)
            {
                return true;
            }
            else
            {
                StartCoroutine(Wait());
                return false;
            }

        }

        public void OnDestroy()
        {
            GameManager.gameManager.onDayModeActivated -= OnDayModeActivated;
            GameManager.gameManager.onNightModeActivated -= OnNightModeActivated;
        }

        // TODO : Gozilla n'a pas de dark/night mode
        public void OnDayModeActivated()
        {
            GetComponent<Animator>().SetBool("", false);
        }

        public void OnNightModeActivated()
        {
            GetComponent<Animator>().SetBool("", true);
        }
    }
}
