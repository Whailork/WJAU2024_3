 using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    // Reference
    public static MapManager mapManager;

    // Variables
    public List<Vector2> pointsRepere;
    public List<Vector2> pointsInverse;

    // Singleton
    private void Awake()
    {
        if (mapManager == null)
        {
            mapManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        pointsRepere.Clear();
        setList();
    }

    void Update()
    {

    }

    public void setList()
    {
        // TODO : if pathName = XXX, set those points
        Vector2 p1 = new Vector2(7.25f, 3.25f);
        Vector2 p2 = new Vector2(7.25f, 0.25f);
        Vector2 p3 = new Vector2(-7.75f, 0.25f);
        Vector2 p4 = new Vector2(-7.75f, -2.75f);
        Vector2 p5 = new Vector2(7.25f, -2.75f);

        pointsRepere.Add(p1);
        pointsRepere.Add(p2);
        pointsRepere.Add(p3);
        pointsRepere.Add(p4);
        pointsRepere.Add(p5);
    }

    /*
    public List<Vector2> getPath(string objectType)
    {
        // Projectile projectileInstance = Instantiate(projectile, transform.position, Quaternion.identity);
        // projectileInstance.goToTarget(targetMonster.transform.position);

        pointsInverse = pointsRepere;
        pointsInverse.Reverse();

        if (objectType == "Monster")//(gameObject.GetType() == typeof(Monster))
        {
            //Monster monsteInstance = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity);
            Debug.Log("MapManager -> getPath = GameObject est un Monster");
            return pointsRepere;
        }

        else if (objectType == "RoadTower")
        {
            Debug.Log("MapManager -> getPath = GameObject est une RoadTower");
            return pointsInverse;
        }
        else
        {
            Debug.Log("MapManager -> getPath = GameObject n'est pas \"Monster\" ou \"RoadTower\"");
            return null;
        }
    }*/
}
