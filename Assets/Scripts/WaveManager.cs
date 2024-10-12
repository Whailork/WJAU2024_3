using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager waveManager;
    private int wave;
    private int nbRemaining;
    private void Awake()
    {
        if (waveManager == null)
        {
            waveManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
