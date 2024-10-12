using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public static MapManager mapManager;
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
        GameManager.gameManager.pointsRepere.Clear();
    }

    void Update()
    {

    }

    void addPoint(Vector2 point)
    {
        GameManager.gameManager.pointsRepere.Add(point);
    }

    List<Vector2> getPath(GameObject gameObject)
    {
        // Projectile projectileInstance = Instantiate(projectile, transform.position, Quaternion.identity);
        // projectileInstance.goToTarget(targetMonster.transform.position);

        if (gameObject.GetType() == typeof(Monster))
        {
            return GameManager.gameManager.pointsRepere;
        }

        else if (gameObject.GetType() == typeof(RoadTower))
        {
            GameManager.gameManager.pointsRepere.Reverse();
            return GameManager.gameManager.pointsRepere;
        }
        else
        {
            Debug.Log("MapManager -> getPath = GameObject n'est pas \"Monster\" ou \"RoadTower\"");
            return null;
        }
    }
}
