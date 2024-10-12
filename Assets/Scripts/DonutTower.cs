using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutTower : Tower
{
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
        foreach (gameManager.getMonsters() monster in Monster)
        {
            distance = Vector2.Distance(this.position, monster.position);

            if (distance ­< donutTowerGrandRayon && distance > donutTowerPetitRayon) {
                targetMonster = monster;

                break;
            }
        }
    }
}
