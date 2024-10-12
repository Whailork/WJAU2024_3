using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private bool isOccupied;
    public RayonTower RayonPrefab;
    public DonutTower DonutPrefab;
    private Tower tower;
    public Vector3 pos;
    
    // Start is called before the first frame update
    
    public void OnMouseDown()
    {
        if (isOccupied)
        {
            return;
        }
        if (GameManager.gameManager.selectedTower != "")
        {
            
            
            isOccupied = true;
            switch (GameManager.gameManager.selectedTower)
            {
            
                case "Donut":
                    Debug.Log("Donut");
                    tower = Instantiate(DonutPrefab,pos,Quaternion.identity); 
                    break;
                case "Rayon":
                    Debug.Log("rayon");
                    tower = Instantiate(RayonPrefab,pos,Quaternion.identity); 
                    break;
                case "Road":
                    //tower = Instantiate();
                    break;
                case "Regular":
                    //tower = Instantiate();
                    break;
            
            }
            GameManager.gameManager.StopEdit();
            // reset selectedTower
            

        }
        
    }

    public void OnEnable()
    {
        

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
        Debug.Log("color white");
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    public void OnDisable()
    {
        GameManager.gameManager.onStartEditMode -= OnStartEditMode;
        GameManager.gameManager.onStopEditMode -= OnStopEditMode;
    }
    void Start()
    {
        pos = GetComponent<Transform>().position;
        GameManager.gameManager.onStartEditMode += OnStartEditMode;
        GameManager.gameManager.onStopEditMode += OnStopEditMode;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
