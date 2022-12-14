using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator animator;

    public void Jump()
    {
        animator.SetTrigger("Jump_trig");
    }

    public void Run()
    {
        animator.SetFloat("Speed_f",1f);
    }

    public void Idle()
    {
        animator.SetFloat("Speed_f",0f);
    }

    public void Die()
    {
        animator.SetBool("Death_b",true);
    }
}
