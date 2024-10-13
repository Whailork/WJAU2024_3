using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class floatinghealthbar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    
    /* si jamais on a des probleme avec les ou les monstres switch 
    [SerializeField] private Camera camera;
    [SerializeField] private Transform target; 
*/
    public void UpdateHealthBar(int currentValue, int maxValue)
    {
        slider.value = currentValue / maxValue;
    }
    
}
