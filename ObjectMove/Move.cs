using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");       // GetAxis() - Horizontal : 수평
        float v = Input.GetAxis("Vertical");         // GetAxis() - Vertical   : 수직

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        transform.Translate(Vector3.right * h);     
        transform.Translate(Vector3.forward * v);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collision" + collision.transform.name);                            
        GetComponent<Rigidbody>().isKinematic = true;                            
        // print("IsKinematic : " + GetComponent<Rigidbody>().isKinematic);      
        gameObject.GetComponent<Rigidbody>().isKinematic = true;                 
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Exit" + collision.collider.name);
    }

    // Trigger는 충돌당할 물체에 설정해준다.

    private void OnTriggerEnter(Collider other)
    {
        print("Collision" + other.name);
        GetComponent<Rigidbody>().isKinematic = false;
        //GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 500f, 400f));
        //other.isTrigger = false;
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    print("Exit" + other.name);
    //    Destroy(other.gameObject);
    //}
}
