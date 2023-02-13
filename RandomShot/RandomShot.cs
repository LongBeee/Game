using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomShot : MonoBehaviour
{
    Transform obj;
    
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            int num = Random.Range(0,3);
            //Instantiate(object, pos[num].position, pos[num].rotaion);
        }
    }
}
