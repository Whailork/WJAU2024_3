using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DonutTower : Tower
{
    // Variables
    public int petitRayon;
    public int grandRayon;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Check if lorsque ennemie est d�truit targetMonster = null?
        if (targetMonster == null || targetOutOfRange())
        {
            Attack();
        }
    }

    void Attack()
    {
        foreach (Monster.Monster enemy in GameManager.gameManager.enemies)
        {
            distance = Vector2.Distance(this.transform.position, enemy.transform.position);

            if (distance < grandRayon && distance > petitRayon)
            {
                targetMonster = enemy;
                break;
            }
        }
    }

    bool targetOutOfRange()
    {
        distance = Vector2.Distance(this.transform.position, targetMonster.transform.position);

        if (distance > grandRayon || distance < petitRayon)
        {
            return true;
        }
        return false;
    }
}
