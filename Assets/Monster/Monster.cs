using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Monster : MonoBehaviour
{
    // Variables
    public int life;
    public int power;
    public bool sleep;
    public bool electric;
    public Collider2D Collider2D;
    public Vector2 targetPosition;

    // TODO : Ajuster vitesse
    public Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetBool("Electric", electric);
        Collider2D = GetComponent<Collider2D>();

        MapManager.mapManager.setList();
    }

    protected void goToTarget(Vector2 target)
    {
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = GetComponent<Rigidbody2D>().velocity.magnitude;
        GetComponent<Animator>().SetFloat("Speed", speed);
        GetComponent<Animator>().SetBool("Sleep", sleep);
        GetComponent<Animator>().SetInteger("Life", life);
    }

    public int updateTargetPoint(int nextPoint)
    {
        float distance = Vector2.Distance(transform.position, targetPosition);

        if (distance <= 0.1)
        {
            nextPoint++;
            targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
        }

        return nextPoint;
    }

    public virtual void IfdarkMode(bool dark)
    {
        if(dark == true)
        {
            sleep = false;
        }
    }

    public int GetPower() { return power; }

    public int GetLife() { return life; }

    public int DamageLife(int attack)
    {
        life -= attack;
        return life;
    }
}
