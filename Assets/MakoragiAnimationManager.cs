using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakoragiAnimationManager : MonoBehaviour {

    private Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }

    public void Jump()
    {
        animator.SetTrigger("is_jumping");
    }
}
