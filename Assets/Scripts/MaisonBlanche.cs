using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class MaisonBlanche : MonoBehaviour
{
    // Variables
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArrayDay;
    public Sprite[] spriteArrayNight;
    public int pointDeVie;
    public int etat;
    public bool isDay;
    public RoadTower tankPrefab;
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        spriteArrayNight = new Sprite[3];
        spriteArrayDay = new Sprite[3];

        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteArrayDay[0] = Resources.Load<Sprite>("d_damage1.png");
        spriteArrayDay[1] = Resources.Load<Sprite>("d_damage2.png");
        spriteArrayDay[2] = Resources.Load<Sprite>("d_damage3.png");

        spriteArrayNight[0] = Resources.Load<Sprite>("n_damage1.png");
        spriteArrayNight[1] = Resources.Load<Sprite>("n_damage2.png");
        spriteArrayNight[2] = Resources.Load<Sprite>("n_damage3.png");

        pos = GetComponent<Transform>().position;

        GameManager.gameManager.onDayModeActivated += OnDayModeActivated;
        GameManager.gameManager.onNightModeActivated += OnNightModeActivated;
        GameManager.gameManager.onStartEditMode+= OnStartEditMode;
        GameManager.gameManager.onStopEditMode += OnStopEditMode;
    }

    // TODO : v�rifier si elle change
    void Update()
    {
        if (GameManager.gameManager.Hp == 0 && etat != 2)
        {
            etat = 2;
            ChangeSprite(etat);
        }
        else if (GameManager.gameManager.Hp < 50 && etat != 1)
        {
            etat = 1;
            ChangeSprite(etat);
        }
        else if (GameManager.gameManager.Hp < 100 && etat != 0)
        {
            etat = 0;
            ChangeSprite(etat);
        }

    }
    public void OnStartEditMode()
    {
        if(GameManager.gameManager.selectedTower == "Road")
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
           


    }

    public void OnStopEditMode()
    {
        Debug.Log("color white");
        GetComponent<SpriteRenderer>().color = Color.white;
    }


    void ChangeSprite(int x)
    {
        if (isDay)
        {
            spriteRenderer.sprite = spriteArrayDay[x];
        }
        else
        {
            spriteRenderer.sprite = spriteArrayNight[x];
        }
    }

    public void OnDestroy()
    {
        GameManager.gameManager.onDayModeActivated -= OnDayModeActivated;
        GameManager.gameManager.onNightModeActivated -= OnNightModeActivated;
        GameManager.gameManager.onStartEditMode -= OnStartEditMode;
        GameManager.gameManager. onStopEditMode -= OnStopEditMode;
    }

    public void OnDayModeActivated()
    {
        isDay = true;
        ChangeSprite(etat);
    }

    public void OnNightModeActivated()
    {
        isDay = false;
        ChangeSprite(etat);
    }

    public void takeDamage(int damages)
    {
        pointDeVie -= damages;
    }

    void changeState()
    {
    }
    public void OnMouseDown()
    {
        if (GameManager.gameManager.money >= tankPrefab.amountToRemove)
        {
            Instantiate(tankPrefab, new Vector3(pos.x, Convert.ToSingle(pos.y + 0.7), pos.z), Quaternion.identity);
        }
       
    }



}
