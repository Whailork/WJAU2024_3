using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ManteReligieuse : Monster
{
    public int nextPoint;
    //public ManteReligieuse() { life = 150; power = 50; sleep = false; electric = true; }

    // Start is called before the first frame update
    void Start()
    {

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

    public void IfSleep()
    {
        if (sleep == true)
        {
            MRAnimateSleep();
            sleep = false;
        }
    }

    public void IfElectric()
    {
        if (electric == true)
        {
            MRAnimateElec();
        }
    }

    public void IfLifeZero()
    {
        if (life == 0)
        {
            MRAnimateDead();
        }
    }

    public void MRAnimateMove()
    {

    }

    public void MRAnimateSleep()
    {

    }

    public void MRAnimateElec()
    {

    }

    public void MRAnimateDead()
    {

    }

}
