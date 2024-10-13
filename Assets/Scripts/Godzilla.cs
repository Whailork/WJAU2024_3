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

            IfSleep();
            IsDead();
            float speed = 500f; //GetComponent<Rigidbody2D>().velocity.magnitude;
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

        public void IfSleep()
        {
            if (sleep == true)
            {
                sleep = false;
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
            //GetComponent<Animator>().SetBool("", false);
        }

        public void OnNightModeActivated()
        {
            //GetComponent<Animator>().SetBool("", true);
        }
    }
}
