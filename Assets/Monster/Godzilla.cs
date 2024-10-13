using UnityEngine;
using System.Collections.Generic;

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

           
            if (dark == true)
            {
                if (dark == true)
                {
                    sleep = true;
                }
            }
           

        }

        //    void Update()
        //    {

        //    }


        //    public void IfdarkMode(bool dark)
        //    {
        //        if (dark == true)
        //        {
        //            if (dark == true)
        //            {
        //                sleep = true;
        //            }
        //        }
        //    }
    }
}
