using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    Animator animator;
    int horizontalValue;
    int veticalValue;
    void Awake()
    {
        animator = GetComponent<Animator>();
        horizontalValue = Animator.StringToHash("Horizontal");
        veticalValue = Animator.StringToHash("Vertical");
    }
    public void ChangeAnimatorValues(float horizontalMovement, float verticalMovement)
    {
        animator.SetFloat(horizontalValue, horizontalMovement, 0.1f, Time.deltaTime);
        animator.SetFloat(veticalValue, verticalMovement, 0.1f, Time.deltaTime);
    }
}
