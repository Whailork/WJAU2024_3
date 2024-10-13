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
            Debug.Log(sleep);
            IsDead();
            float speed = GetComponent<Rigidbody2D>().velocity.magnitude;
            GetComponent<Animator>().SetBool("Sleep", false);
            GetComponent<Animator>().SetFloat("Speed", speed);
            GetComponent<Animator>().SetInteger("Life", life);
            GetComponent<Animator>().SetBool("Electric", false);


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

        //public bool DarkMode(bool d)
        //{
        //    if (d == true)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //public bool IfSleep(bool s)
        //{
        //    Debug.Log("Godzilla s endort");
        //    if (s == true)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        StartCoroutine(Wait());
        //        return false;
        //    }

        //}

        public void OnDestroy()
        {
            GameManager.gameManager.onDayModeActivated -= OnDayModeActivated;
            GameManager.gameManager.onNightModeActivated -= OnNightModeActivated;
        }

        // TODO : Gozilla n'a pas de dark/night mode
        public void OnDayModeActivated()
        {
            GetComponent<Animator>().SetBool("Sleep", false);
        }

        public void OnNightModeActivated()
        {
            GetComponent<Animator>().SetBool("Sleep", true);
        }
    }
}
