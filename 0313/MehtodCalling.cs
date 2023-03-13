using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MehtodCalling : MonoBehaviour
{
    GameObject mngObj;
    SampleMethod samScript;
    void Start()
    {
        mngObj = GameObject.Find("MethodManager");
        samScript = mngObj.GetComponent<SampleMethod>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            samScript.Method1();
        }
        else if(Input.GetKeyDown(KeyCode.K))
        {
            samScript.Method2();
        }
        else if(Input.GetKeyDown(KeyCode.L))
        {
            samScript.Method3();
        }
    }
}
