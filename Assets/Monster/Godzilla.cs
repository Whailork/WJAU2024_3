using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Godzilla : Monster
{

    //public Godzilla() { life = 100; power = 20; sleep = false; electric = false; }

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
