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

    
    public Vector2 targetPosition;

    // TODO : Ajuster vitesse
    public float speed = 500.0f;
    public Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        sleep = false;
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

    public void IfdarkMode(bool dark)
    {
        if(dark == true)
        {
            sleep = true;
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
