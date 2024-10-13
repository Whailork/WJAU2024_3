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
        speedText.GetComponent<TextMeshProUGUI>().text = selectedTower.fireRate.ToString();

        rangeText.GetComponent<TextMeshProUGUI>().text = selectedTower.range.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
