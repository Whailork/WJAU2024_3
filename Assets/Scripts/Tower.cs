using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour, ITower
{
    // References
    //public Monster targetMonster;
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

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnProjectile()
    {

    }

    void Attack()
    {
        //projectile.moveto = targetMonster.position;
    }
}
