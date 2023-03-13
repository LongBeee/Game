using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoTest1 : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        print(gameObject.name + " : 1");
        yield return new WaitForSeconds(2.0f);  
        print(gameObject.name + " : 2");
        print(gameObject.name + " : 3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
