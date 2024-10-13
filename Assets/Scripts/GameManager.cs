using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
// using Unity.VisualScripting;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public List<Monster.Monster> enemies; // Enemies
    private List<string> towers; // Towers
    public int Hp;
    public int money = 0;
    public string selectedTower;
    private bool editMode;
    public Action onStartEditMode;
    public Action onStopEditMode;
    public GameObject moneyWidget;
    public GameObject hpWidget;
    public Action onNightModeActivated;
    public Action onDayModeActivated;
    public Input mode;

    public void AddMoney(int amount)
    {
        money += amount;
        moneyWidget.GetComponent<TextMeshPro>().text = money + "";
        Debug.Log("Money increased: " + money);
    }
    
    public void RemoveMoney(int amount)
    {
        money -= amount;
        moneyWidget.GetComponent<TextMeshPro>().text = money + "";
        Debug.Log("Money decreased: " + money);
    }

    public void takeDamage(int amountDamage)
    {
        Hp -= amountDamage;
        hpWidget.GetComponent<TextMeshPro>().text = Hp + "";
        //TODO : faire que quand tu est à 0 ça finit la partie
    }

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

    public void OnNightModeActivated()
    {
        //nightMode = true;


    }
    public void OnDayModeActivated()
    {

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
        hpWidget.GetComponent<TextMeshProUGUI>().text = Hp + "";
        moneyWidget.GetComponent<TextMeshProUGUI>().text = money + "";
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

        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("N clicked");

            onNightModeActivated?.Invoke();
        }
    }
}
