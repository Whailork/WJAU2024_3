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
<<<<<<< HEAD
=======

    
    public Vector2 targetPosition;

    // TODO : Ajuster vitesse
    public float speed = 500.0f;
    public Vector2 velocity;
>>>>>>> origin/main

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetBool("Electric", electric);

        MapManager.mapManager.setList();
    }

    protected void goToTarget(Vector2 target)
    {
        float maxDistance = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target, maxDistance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = GetComponent<Rigidbody2D>().velocity.magnitude;
        GetComponent<Animator>().SetFloat("Move", move);
        GetComponent<Animator>().SetBool("Sleep", sleep);
        GetComponent<Animator>().SetInteger("Life", life);
    }

<<<<<<< HEAD
    public virtual void IfdarkMode(bool dark)
=======
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

    public void IfdarkMode(bool dark)
>>>>>>> origin/main
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
