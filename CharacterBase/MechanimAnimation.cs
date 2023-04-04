using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechanimAnimation : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        animator.SetFloat("fSpeed", v);
        animator.SetFloat("DirSpeed", h);

    }

    
}
