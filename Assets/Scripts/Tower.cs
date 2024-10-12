using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Tower : MonoBehaviour, ITower
{
    // References
    public Monster targetMonster;
    public Projectile projectile;
    public GameObject upgradeMenu;
    
    // Variables
    public float distance;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        
            
    }
    public void attack() {

    }

    public void SpawnProjectile()
    {
        Projectile projectileInstance = Instantiate(projectile, transform.position, Quaternion.identity);
        projectileInstance.goToTarget(targetMonster.transform.position);
    }
}