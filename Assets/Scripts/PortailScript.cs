using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortailScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void allFalse()
    {
        GetComponent<Animator>().SetBool("start", false);
    }

    public void allTrue()
    {
        GetComponent<Animator>().SetBool("start", true);
    }

   
}
