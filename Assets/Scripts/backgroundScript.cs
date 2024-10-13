using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class backgroundScript : MonoBehaviour
{
    public Sprite imgBackground;

    // Start is called before the first frame update
    void Start()
    {
        imgBackground = GetComponent<Sprite>();

        imgBackground = Resources.Load<Sprite>(MapManager.mapManager.pathImageBackground);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
