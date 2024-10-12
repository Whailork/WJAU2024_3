using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public List<Monster> enemies; // Enemies
    private List<string> towers; // Towers
    public int Hp;
    public int money;
    public string selectedTower;
    private bool editMode;
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
        
        //Debug.Log("initiate edit mode");
        onStartEditMode += OnStartEditMode;
        onStopEditMode += OnStopEditMode;

    }

    public void TowerIconClicked()
    {
        onStartEditMode?.Invoke();
    }

    public void OnStartEditMode()
    {
        editMode = true;
    }

    public void OnStopEditMode()
    {
        editMode = false;
    }

    private void OnDisable()
    {
        onStartEditMode -= OnStartEditMode;
        onStopEditMode -= OnStopEditMode;
    }

    public void StopEdit()
    {
        //Debug.Log("tour placed");
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
        if (editMode)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            { 
                onStopEditMode?.Invoke();
            
            }
        }
        
    }
}
