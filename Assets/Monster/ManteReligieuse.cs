using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManteReligieuse : Monster
{

    //public ManteReligieuse() { life = 150; power = 50; sleep = false; electric = true; }

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
    //        MRAnimateMove();
    //    }
    //}

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
