using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    // Reference
    public static MapManager mapManager;

    // Variables
    public List<Vector2> pointsRepere;
    public List<Vector2> pointsInverse;

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
    }

    void Update()
    {

    }

    void addPoint(Vector2 point)
    {
        pointsRepere.Add(point);
    }

    List<Vector2> getPath(GameObject gameObject)
    {
        // Projectile projectileInstance = Instantiate(projectile, transform.position, Quaternion.identity);
        // projectileInstance.goToTarget(targetMonster.transform.position);

        pointsInverse = pointsRepere;
        pointsInverse.Reverse();

        if (gameObject.GetType() == typeof(Monster))
        {
            return pointsRepere;
        }

        else if (gameObject.GetType() == typeof(RoadTower))
        {
            return pointsInverse;
        }
        else
        {
            Debug.Log("MapManager -> getPath = GameObject n'est pas \"Monster\" ou \"RoadTower\"");
            return null;
        }
    }
}
