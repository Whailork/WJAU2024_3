using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RayonTower : Tower
{
    // Variables
    public int rayonTowerRayon;

    void Start()
    {
        
    }

    void Update()
    {
        // Check if lorsque ennemie est d�truit targetMonster = null?
        if (targetMonster == null || targetOutOfRange()) {
            Attack();
        }

    }

    void Attack()
    {
        foreach (Monster.Monster enemy in GameManager.gameManager.enemies)
        {
            distance = Vector2.Distance(this.transform.position, enemy.transform.position);

            if (distance < rayonTowerRayon)
            {
                targetMonster = enemy;
                break;
            }
        }
    }

    // TODO : if targetMonster sort du rayon ou si est d�truit targetMonster = null
    bool targetOutOfRange()
    {
        distance = Vector2.Distance(this.transform.position, targetMonster.transform.position);

        if (distance > rayonTowerRayon)
        {
            return true;
        }
        return false;
    }
}
