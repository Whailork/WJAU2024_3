using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITower
{
    // Références
    public Monster targetMonster;
    public Projectile projectile;
    public GameManager gameManager;

    // Variables
    public string towerType;
    public int rayonTowerRayon;
    public int donutTowerPetitRayon;
    public int donutTowerGrandRayon;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        targetMonster = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    
    /*
    void RayonAttack()
    {
        foreach (gameManager.getMonsters() monster in Monster)
        {
            distance = Vector2.Distance(this.position, monster.position);

            if (distance ­< rayonTowerRayon) {
                targetMonster = monster;

                break;
            }
        }
    }
    *
}
