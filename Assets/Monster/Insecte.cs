using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Insecte : Monster
{
    public int nextPoint;
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


    public void IfElectric()
    {
        if (electric == true)
        {
            IseAnimateElec();
        }
    }

    public void IfLifeZero()
    {
        if (life == 0)
        {
            IseAnimateDead();
        }
    }

    public void IseAnimateMove()
    {

    }

    public void IseAnimateSleep()
    {

    }

    public void IseAnimateElec()
    {

    }

    public void IseAnimateDead()
    {

    }

}
