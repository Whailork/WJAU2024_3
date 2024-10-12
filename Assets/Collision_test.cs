using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_test : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEnter_Vert");
    }
}
