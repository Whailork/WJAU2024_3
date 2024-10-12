using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class RoadTower : Tower
{
    // Variables 
    public int pointDeVie;
    public int infligedDamaged;
    public int nextPoint;
    public Vector2 targetPosition;


    void Start()
    {
        nextPoint = MapManager.mapManager.pointsRepere.Count - 1;

        
        // Collider2D.enabled = true;

        /*
        Debug.Log("Next point = " + nextPoint);

        targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
        goToTarget(targetPosition);

        Debug.Log("X : " + targetPosition.x + "" + targetPosition.y);
        */
    }

    /*
    void Awake()
    {
        Collider2D = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;

        Collider2D.enabled = true;

        rb.isKinematic = false;
    }
    */

    private void FixedUpdate()
    {

        if (targetPosition == Vector2.zero)
        {
            targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
            goToTarget(targetPosition);
            nextPoint--;
        }
        else if (nextPoint >= -1)
        {

            nextPoint = updateTargetPoint(nextPoint);
            goToTarget(targetPosition);
        }
    }

    protected void goToTarget(Vector2 target)
    {
        transform.position = Vector2.MoveTowards(transform.position, target, (Time.deltaTime* 10.00f));
    }

    public int updateTargetPoint(int nextPoint)
    {
        float distance = Vector2.Distance(transform.position, targetPosition);

        if (distance <= 0.1)
        {
            
            targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
            nextPoint--;
        }

        return nextPoint;
    }

    void Attack()
    {
    }

    
    
}
