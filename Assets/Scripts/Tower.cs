using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Tower : MonoBehaviour, ITower
{
    // References
    public string targetMonster; // TODO : string => Monster
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
        Projectile projectileInstance = Instantiate(projectile, transform.position, Quaternion.identity);
        // TODO : Decommenter
        // projectile.setTarget(targetMonster.transform.position);
    }

    public void attack() { }
}