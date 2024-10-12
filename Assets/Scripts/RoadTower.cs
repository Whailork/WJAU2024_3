using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadTower : Tower
{
    // Variables 
    public int pointDeVie;
    public int infligedDamaged;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Attack()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.GetType() == typeof(Monster.Monster))
        {
            Debug.Log("Collision with Monster");

            // TODO : redefinir la descente des pdv
            // Apply collision damage
            pointDeVie -= 10;
        }
    }
}
