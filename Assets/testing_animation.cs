using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing_animation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play("Idle Serpent");

    }

}
