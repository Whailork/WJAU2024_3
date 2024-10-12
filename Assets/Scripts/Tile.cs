using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private bool isOccupied;

    private ITower tower;
    
    // Start is called before the first frame update
    
    public void OnMouseDown()
    {
        if (GameManager.gameManager.selectedTower != "")
        {
            GameManager.gameManager.TourPlaced();
            isOccupied = true;
            switch (GameManager.gameManager.selectedTower)
            {
            
                case "Donut":
                
                    //tower = Instantiate(); on instancie avec ressource.load
                    break;
                case "Rayon":
                    //tower = Instantiate();
                    break;
                case "Road":
                    //tower = Instantiate();
                    break;
                case "Regular":
                    //tower = Instantiate();
                    break;
            
            }
            // reset selectedTower
            

        }
        
    }

    public void OnEnable()
    {
        GameManager.gameManager.onStartEditMode += OnStartEditMode;
        GameManager.gameManager.onStopEditMode += OnStopEditMode;

    }
    
    

    public void OnStartEditMode()
    {
        if (isOccupied)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        
    }

    public void OnStopEditMode()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    public void OnDisable()
    {
        GameManager.gameManager.onStartEditMode -= OnStartEditMode;
        GameManager.gameManager.onStopEditMode -= OnStopEditMode;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
