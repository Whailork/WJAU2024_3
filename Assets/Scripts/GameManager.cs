using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public List<Monster> enemies; // Enemies
    private List<string> towers; // Towers
    private int Hp;
    private int money;
    private string selectedTower;

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

    }


    public void TourPlaced()
    {
        Debug.Log("tour placed");
        selectedTower = "";
        onStopEditMode?.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
