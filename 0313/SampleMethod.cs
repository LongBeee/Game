using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMethod : MonoBehaviour
{
    public void Method1()
    {
        StartCoroutine("CalledMethod1");
    }
    public void Method2()
    {
        Invoke("CalledMethod2",2.0f);
    }
    public void Method3()
    {
        print("Method3");
    }

    IEnumerator CalledMethod1() // Coroutain
    {
        yield return new WaitForSeconds(2.0f);
        print("Coroutain");
    }

    private void CalledMethod2() // Invoke
    {
        print("Invoke");
    }
}
