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

    public SpriteRenderer spriteRenderer;
    public Sprite nightSprite;

    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(fireCountDown());

        GameManager.gameManager.onDayModeActivated += OnDayModeActivated;
        GameManager.gameManager.onNightModeActivated += OnNightModeActivated;
    }

    public void OnDayModeActivated()
    {
        GetComponent<Animator>().SetBool("Nigh", false);
        Debug.Log("Night = " + GetComponent<Animator>().GetBool("Night"));
    }

    public void OnNightModeActivated()
    {
        GetComponent<Animator>().SetBool("Night", true);
        Debug.Log("Night = " + GetComponent<Animator>().GetBool("Night"));
    }

    // Update is called once per frame
    void Update()
    {
        // Check if lorsque ennemie est detruit targetMonster = null?
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
            animator.SetTrigger("Fire");
        }
    }
    public void OnDestroy()
    {
        StopCoroutine(fireCountDown());
    }
}