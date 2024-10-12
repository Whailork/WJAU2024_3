using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayonTower : Tower
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

        // string => Monster
        foreach (string enemy in gameManager.enemies)
        {
            // TODO : calculer distance
        }

        /*
         distance = Vector2.Distance(this.position, monster.position);

            if (distance ­< rayonTowerRayon) {
                targetMonster = monster;

                break;
            }
         */
    }
}
