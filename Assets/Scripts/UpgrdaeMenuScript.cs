using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgrdaeMenuScript : MonoBehaviour
{
    public Tower selectedTower;

    public GameObject powerText;
    public GameObject speedText;
    public GameObject rangeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void openMenu(Tower selectedtower)
    {
        
        GetComponent<Animator>().SetBool("open",true);
        this.selectedTower = selectedtower;
        
        Debug.Log("power : " + selectedtower.power);
        
        setValues();
    }

    public void closeMenu()
    {
        GetComponent<Animator>().SetBool("open",false);
    }

    public void setValues()
    {
        //powerText = transform.GetChild(0).gameObject;
        
        Debug.Log(selectedTower.power);
        powerText.GetComponent<TextMeshProUGUI>().text = selectedTower.power + "";
        speedText.GetComponent<TextMeshProUGUI>().text = Convert.ToString(selectedTower.fireRate);

        rangeText.GetComponent<TextMeshProUGUI>().text = Convert.ToString(selectedTower.range);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void upgradePower()
    {
        selectedTower.power += 5;
        setValues();
    }

    public void upgradeSpeed()
    {
        selectedTower.fireRate = selectedTower.fireRate / 2;
        setValues();

    }

    public void upgradeRange()
    {
        selectedTower.range += 1;
        setValues();

    }
}
