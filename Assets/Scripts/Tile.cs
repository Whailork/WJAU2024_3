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
    public RoadTower TankPrefab;
    public RayonTower BunkerPrefab;
    private Tower tower;
    public Vector3 pos;

    public SpriteRenderer spriteRenderer;
    public Sprite nightSprite;
    public Sprite daySprite;

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
                    
                    tower = Instantiate(DonutPrefab,new Vector3(pos.x,Convert.ToSingle(pos.y+0.7),pos.z),Quaternion.identity); 
                    break;
                case "Rayon":
                    Debug.Log("Rayon");
                    tower = Instantiate(RayonPrefab,new Vector3(pos.x,Convert.ToSingle(pos.y+0.7),pos.z),Quaternion.identity); 
                    break;
                case "Road":
                    tower = Instantiate(TankPrefab,new Vector3(pos.x,Convert.ToSingle(pos.y+0.7),pos.z),Quaternion.identity); 
                    //tower = Instantiate();
                    break;
                case "Bunker":
                    tower = Instantiate(BunkerPrefab,new Vector3(pos.x,Convert.ToSingle(pos.y+0.7),pos.z),Quaternion.identity); 
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
        spriteRenderer = GetComponent<SpriteRenderer>();
        pos = GetComponent<Transform>().position;
        GameManager.gameManager.onStartEditMode += OnStartEditMode;
        GameManager.gameManager.onStopEditMode += OnStopEditMode;

        GameManager.gameManager.onDayModeActivated += OnDayModeActivated;
        GameManager.gameManager.onNightModeActivated += OnNightModeActivated;

        nightSprite = Resources.Load<Sprite>("n_x.png");
        daySprite = Resources.Load<Sprite>("d_x.png");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDayModeActivated()
    {
        spriteRenderer.sprite = daySprite;
    }

    public void OnNightModeActivated()
    {
        spriteRenderer.sprite = nightSprite;
    }
}
