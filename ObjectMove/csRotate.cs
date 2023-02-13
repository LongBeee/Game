using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotate : MonoBehaviour
{
    public float speed = 10.1f;

    // Start is called before the first frame update
    void Start()  
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            speed = 5000;
        }
        this.transform.Rotate(new Vector3(0,1,0) * speed * Time.deltaTime);

        speed *= 0.99f;
    }
}
