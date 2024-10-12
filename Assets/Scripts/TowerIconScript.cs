using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerIconScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string towerType;

    public void OnMouseDown()
    {
        GameManager.gameManager.selectedTower = towerType;
        GameManager.gameManager.TowerIconClicked();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
