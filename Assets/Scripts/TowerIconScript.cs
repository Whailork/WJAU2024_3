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
        //Debug.Log(towerType);
        if (towerType == "Tank")
        {
            //FONCTION QUI MET EN PLACE DU MAISON BLANCHE 
        }
        else
        {
            GameManager.gameManager.TowerIconClicked();
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
