using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected int life;
    protected int power;
    protected bool sleep;
    protected bool electric;
    protected Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IfdarkMode(bool dark)
    {
        if(dark == true)
        {
            sleep = true;
        }
    }

    public int GetPower() { return power; }

    public int GetLife() { return life; }

    public int DamageLife(int attack)
    {
        life -= attack;
        return life;
    }

}
