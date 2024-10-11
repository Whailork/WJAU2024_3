using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using UnityEngine;

public class ITower : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void SpawnProjectile()
    {

    }

    void Attack()
    {
        if (targetMonster != null)
        {
            Vector2 targetPosition = targetMonster.position;

            SpawnProjectile();

            switch (towerType)
            {
                case "donutTower":
                    DonutTowerAttack(targetPosition);
                    break;

                case "rayonTower":
                    RayonTowerAttack(targetPosition);
                    break;

                case "vTower":
                    VTowerAttack(targetPosition);
                    break;

                default:
                    Debug.LogError("Error with Itower -> Attack -> towerType");
                    break;
            }
        }
    }

    void DonutTowerAttack(Vector2 targetPosition)
    {
        foreach (gameManager.getMonsters() objet in ObjetoAOcultar)
        {
            objet.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, alphaLevel);
        }
    }

    void RayonTowerAttack(Vector2 targetPosition)
    {
        Vector2.Distance(this.position, targetPosition);
    }

    void 
}
