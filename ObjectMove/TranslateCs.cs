using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateCs : MonoBehaviour
{
    //GameObject box;
    Transform box;
    void Start()
    {
        box = GameObject.Find("Cube").GetComponent<Transform>();
    }
    int dir = 1;
    // Update is called once per frame
    void Update()
    {
        /*
        if(transform.position.x<-5 || transform.position.x>5)
        {
            dir *= -1;  //dir=dir*-1;
        }
        */
        if (transform.position.x > 5)
        {
            dir = -dir;
            transform.position = new Vector3(4.8f, transform.position.y, transform.position.z);
            box.transform.position = new Vector3(-5.0f, box.position.y, box.position.z);
        }
        else if (transform.position.x < -5)
        {
            dir = -dir;
            transform.position = new Vector3(-4.8f, transform.position.y, transform.position.z);
            box.transform.position = new Vector3(5.0f, box.position.y, box.position.z);
        }
        this.transform.Translate(Vector3.right * 3 * Time.deltaTime * dir);
    }
}
