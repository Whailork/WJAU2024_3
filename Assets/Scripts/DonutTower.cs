using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DonutTower : Tower
{
    // Variables
    public int petitRayon;
    public int grandRayon;
    protected Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(fireCountDown());
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
            animator.SetTrigger("shoot");
        }
    }
    public void OnDestroy()
    {
        StopCoroutine(fireCountDown());
    }
}
