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
        nextPoint = 0;
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
