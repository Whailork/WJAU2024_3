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

    public void setList()
    {
        // TODO : if pathName = XXX, set those points
        Vector2[] tabXXX = {
            new Vector2(-7.25f, 3.25f),
            new Vector2(7.25f, 3.25f),
            new Vector2(7.25f, 0.25f),
            new Vector2(-7.75f, 0.25f),
            new Vector2(-7.75f, -2.75f),
            new Vector2(7.25f, -2.75f)
        };

        for (int x = 0; x < tabXXX.Length; x++)
        {
            pointsRepere.Add(tabXXX[x]);
        }
    }
}
