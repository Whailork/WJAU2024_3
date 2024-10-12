using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CancelEditScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void OnEnable()
    {
        GameManager.gameManager.onStartEditMode += setVisible;
    }

    public void OnDisable()
    {
        GameManager.gameManager.onStopEditMode -= setInvisible;
    }

    public void OnBtnPressed()
    {
        GameManager.gameManager.StopEdit();
    }

    private void setVisible()
    {
        gameObject.SetActive(true);
    }
    private void setInvisible()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
