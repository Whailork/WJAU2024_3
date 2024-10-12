using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public List<string> enemies; // Enemies
    private List<string> towers; // Towers
    public int Hp;
    public int money;
    public string selectedTower;
    public Action onStartEditMode;
    public Action onStopEditMode;
    
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

    public void TourPlaced()
    {
        selectedTower = "";
    }

    public void OnStartEditMode()
    {
        
    }

    public void OnStopEditMode()
    {
        
    }

    public void OnEnable()
    {
        onStartEditMode += OnStartEditMode;
        onStopEditMode += OnStopEditMode;

    }

    public void OnDisable()
    {
        onStartEditMode -= OnStartEditMode;
        onStopEditMode -= OnStopEditMode;
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
