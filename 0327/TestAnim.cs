using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnim : MonoBehaviour
{
    public int Speed;
    void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)) print("Speed : " + Speed);
    }

    public void State1()
    {
        print("State1");
    }

    public void State2()
    {
        print("State2");
    }

}
