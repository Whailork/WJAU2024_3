using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Godzilla : Monster
{

    //public Godzilla() { life = 100; power = 20; sleep = false; electric = false; }

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
        if(targetPosition == Vector2.zero)
        {
            targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
        }

        if (nextPoint < MapManager.mapManager.pointsRepere.Count)
        {
            nextPoint = updateTargetPoint(nextPoint);
            goToTarget(targetPosition);
        }

    }

    void Update()
    {


    }

    public override void IfdarkMode(bool dark)
    {
        if (dark == true)
        {
            sleep = true;
        }
    }

    // Enlever car faisant faire des jumps durant le déplacement
    /*
    public Vector2 Seek(Vector2 target)
    {
        Vector2 desiredVelocity = target - (Vector2)transform.position;
        desiredVelocity.Normalize();
        desiredVelocity *= speed;

        Vector2 steering = desiredVelocity - velocity;
        steering = Vector2.ClampMagnitude(steering, speed);

        return steering;
    }
    */


    //public void IfMove()
    //{
    //    if (position.x != 0 || position.y != 0)
    //    {
    //        GodAnimateMove();
    //    }
    //}

    public void IfSleep()
    {
        if (sleep == true)
        {
            GodAnimateSleep();
            sleep = false;
        }
    }

    public void IfLifeZero()
    {
        if (life == 0)
        {
            GodAnimateDead();
        }
    }

    public void GodAnimateMove()
    {

    }

    public void GodAnimateSleep()
    {

    }

    public void GodAnimateDead()
    {

    }



}
