using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RayonTower : Tower
{
    // Variables
    public int rayonTowerRayon;

    protected Animator animator;
    private static readonly int Open = Animator.StringToHash("open");

    void Start()
    {
        range = rayonTowerRayon;
        animator = GetComponent<Animator>();
        StartCoroutine(fireCountDown());
        GameManager.gameManager.RemoveMoney(amountToRemove);
        GameManager.gameManager.onDayModeActivated += OnDayModeActivated;
        GameManager.gameManager.onNightModeActivated += OnNightModeActivated;
    }
    
    public void OnMouseDown()
    {
        GameObject menu = GameObject.Find("UpgradeMenu");
        menu.GetComponent<UpgrdaeMenuScript>().openMenu(this);
       
    }

    void Update()
    {
        // Check if lorsque ennemie est d�truit targetMonster = null?
        range = rayonTowerRayon;
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
            targetMonster = null;
            return true;
        }
        return false;
    }

    private IEnumerator fireCountDown()
    {
        while (true)
        {
            
            if (targetMonster != null)
            {
                fire();
                
            }
            yield return new WaitForSeconds(fireRate);
           
            
        }
    }

    public void fire()
    {
        if (targetMonster.DamageLife(power) <= 0)
        {
            animator.SetTrigger("Fire");
        }
    }

    public void OnDestroy()
    {
        StopCoroutine(fireCountDown());
        GameManager.gameManager.onDayModeActivated -= OnDayModeActivated;
        GameManager.gameManager.onNightModeActivated -= OnNightModeActivated;

    }

    public void OnDayModeActivated()
    {
        GetComponent<Animator>().SetBool("Night", false);
    }

    public void OnNightModeActivated()
    {
        GetComponent<Animator>().SetBool("Night", true);
    }
}