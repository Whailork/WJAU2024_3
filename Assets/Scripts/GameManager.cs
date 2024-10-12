using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public List<Monster> enemies; // Enemies
    private List<string> towers; // Towers
    public int Hp;
    public int money;
    public string selectedTower;
    public Action onStartEditMode;
    public Action onStopEditMode;

    // Ajouter par coco
    public List<Vector2> pointsRepere;

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

    public void TowerIconClicked()
    {
        onStartEditMode?.Invoke();
    }

    public void OnStartEditMode()
    {
        
    }

    public void OnStopEditMode()
    {
        
    }

    private void OnEnable()
    {
        onStartEditMode += OnStartEditMode;
        onStopEditMode += OnStopEditMode;
    }

    private void OnDisable()
    {
        onStartEditMode -= OnStartEditMode;
        onStopEditMode -= OnStopEditMode;
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
