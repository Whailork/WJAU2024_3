using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaisonBlanche : MonoBehaviour
{
    // Variables
    public int pointDeVie;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damages)
    {
        pointDeVie -= damages;
    }

    void changeState()
    {

    }
}
