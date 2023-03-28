using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCtrl : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            anim.SetTrigger("Rotation");
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Scale");
        }
    }
}
