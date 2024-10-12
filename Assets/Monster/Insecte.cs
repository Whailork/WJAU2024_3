using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insecte : Monster
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
    //        IseAnimateMove();
    //    }
    //}

    public void IfSleep()
    {
        if (sleep == true)
        {
            IseAnimateSleep();
            sleep = false;
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
