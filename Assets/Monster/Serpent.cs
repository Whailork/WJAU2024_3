using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serpent : Monster
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void IfMove()
    //{
    //    if (position.x != 0 || position.y != 0)
    //    {
    //        SepAnimateMove();
    //    }
    //}

    public void IfSleep()
    {
        if (sleep == true)
        {
            SepAnimateSleep();
            sleep = false;
        }
    }

    public void IfLifeZero()
    {
        if (life == 0)
        {
            SepAnimateDead();
        }
    }

    public void SepAnimateMove()
    {

    }

    public void SepAnimateSleep()
    {

    }

    public void SepAnimateDead()
    {

    }

}
