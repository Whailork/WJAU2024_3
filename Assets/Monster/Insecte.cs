using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insecte : Monster
{

    public Insecte()
    {
        life = 50;
        power = 5;
        sleep = false;
        electric = true;
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Change_Sleep();
    }

}
