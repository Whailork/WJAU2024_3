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
        nextPoint = (MapManager.mapManager.pointsRepere.Count) - 1;

        GameManager.gameManager.onDayModeActivated += OnDayModeActivated;
        GameManager.gameManager.onNightModeActivated += OnNightModeActivated;
    }

    private void FixedUpdate()
    {
        Debug.Log("Next point : " + nextPoint);

        // Tant que le prochain point existe
        if (nextPoint >= -1)
        {
            updateTarget();
            
        }

        goToTarget(targetPosition);
    }

    protected void goToTarget(Vector2 target)
    {
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime);
    }

    public void updateTarget()
    {
        if (targetPosition != Vector2.zero)
        {
            float distance = Vector2.Distance(transform.position, targetPosition);

            if (distance <= 0.1)
            {
                Debug.Log(nextPoint);
                nextPoint--;
                targetPosition = MapManager.mapManager.pointsRepere[nextPoint];

            }
        }
        else
        {
            targetPosition = MapManager.mapManager.pointsRepere[nextPoint];
        }
    }

    public void takeDamage(int damages)
    {
        pointDeVie -= damages;
    }

    void Attack()
    {
    }

    public void OnDestroy()
    {
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