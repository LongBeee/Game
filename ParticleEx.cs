using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEx : MonoBehaviour
{
    public GameObject partiObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            GameObject obj = Instantiate(partiObj);
            obj.GetComponent<ParticleSystem>().Play();
        }
    }
}
