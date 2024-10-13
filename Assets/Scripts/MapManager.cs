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
    public List<PathsDatas> maps;

    public int currentLevel;
    public PathsDatas currentMap;

    public string pathImageBackground;

    // Singleton
    private void Awake()
    {
        if (mapManager == null)
        {
            mapManager = this;
            DontDestroyOnLoad(this);

            pointsRepere.Clear();
            setList();
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
    }

    void Update()
    {

    }
    /*
    public void addMap(PathsDatas data)
    {
        maps.Add(data);
    }

    public void setCurrentMap(int index)
    {
        currentLevel = index;
        currentMap = maps[currentLevel];
    }
    */

    // TODO : Verifier la logique
    public void setList()
    {
        if(maps.Count != 0)
        {
            // currentLevel est donn�e lors du choix du niveau
            currentLevel = 1; // TODO : � retirer
            currentMap = maps[currentLevel - 1];
            

            for (int x = 0; x < currentMap.tabDePoints.Length; x++)
            {
                pointsRepere.Add(currentMap.tabDePoints[x]);
            }
        }
        else
        {
            Debug.LogError("maps non setter!!!");
        }
    }

    public void setBackground()
    {

    }
}
